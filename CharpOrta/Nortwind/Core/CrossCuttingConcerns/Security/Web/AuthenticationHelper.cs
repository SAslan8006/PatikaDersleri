using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.CrossCuttingConcerns.Security.Web
{
    public class AuthenticationHelper
    {
        public static void CreateAuthCookie(Guid id, string userName, string email, DateTime expiration, string[] roles, bool rememeberMe, string firsName, string lastName) 
        {
            var authentication = new FormsAuthenticationTicket(1, userName, DateTime.Now, expiration, rememeberMe,
                CreateAuthTags(email, roles, firsName, lastName,id));
            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpContext.Current.Reponse.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        }

        private static object CreateAuthTags(string email, string[] roles, string firsName, string lastName,Guid id)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(email);
            stringBuilder.Append("|");
            for (int i = 0; i < roles.Length; i++)
            {
                stringBuilder.Append(roles[i]);
                if (i < roles.Length - 1)
                { 
                    stringBuilder.Append(',');
                }
            }
            stringBuilder.Append("|");
            stringBuilder.Append(firsName);
            stringBuilder.Append("|");
            stringBuilder.Append(lastName);
            stringBuilder.Append("|");
            stringBuilder.Append(id);
            return stringBuilder.ToString();

        }
    }
}
