﻿using Microsoft.IdentityModel.Tokens;
using Mobembo.cd_Back_c____.Data_Access.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Mobembo.cd_Back_c____.Security
{
    public class Constente : IConstente
    {
        public Personne Connected { get; set; }
        public static String RoleAd { get { return "Admin"; } }
        public static String RoleCl { get { return "Client"; } }
        public static String Log { get { return "AS%54_!t"; } }
        public static long Expires { get { return 1 * 24 * 3600 * 1000; } } // 1 jour
        public static string SecretToken { get { return "je kifais trop le manga Sakura Card Captor"; } }
        private Context Context = new Context();

        public string GenerateToken(List<Claim> cleams)
        {
            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Constente.SecretToken));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(cleams),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    Key,
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string GetMail(string accessToken)
        {
            string token = accessToken;
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtSecurityToken = handler.ReadJwtToken(token);
            string jti = jwtSecurityToken.Claims.First(claim => claim.Type == "email").Value;

            return jti;
        }

        public void Mapersonne(string accessToken)
        {
            Connected = Context.personnes.FirstOrDefault(p => p.Email == GetMail(accessToken));
        }
    }
}
