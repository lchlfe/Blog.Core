﻿using System.IO;

namespace Blog.Core.Common.AppConfig
{
    /// <summary>
    /// 读取密钥，如果文件有值就读取文件，否正读取配置文件
    /// </summary>
    public class AppSecretConfig
    {
        private static string Audience_Secret = Appsettings.app(new string[] { "Audience", "Secret" });
        private static string Audience_Secret_File = Appsettings.app(new string[] { "Audience", "SecretFile" });


        public static string Audience_Secret_String => InitAudience_Secret();


        private static string InitAudience_Secret()
        {
            var securityString = DifDBConnOfSecurity(Audience_Secret_File);
            if (!string.IsNullOrEmpty(Audience_Secret_File)&& !string.IsNullOrEmpty(securityString))
            {
                return securityString;
            }
            else
            {
                return Audience_Secret;
            }

        }

        private static string DifDBConnOfSecurity(params string[] conn)
        {
            foreach (var item in conn)
            {
                try
                {
                    if (File.Exists(item))
                    {
                        return File.ReadAllText(item).Trim();
                    }
                }
                catch (System.Exception) { }
            }

            return "";
        }

    }

}
