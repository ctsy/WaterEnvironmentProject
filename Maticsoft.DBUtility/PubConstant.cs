using System;
using System.Configuration;
namespace Maticsoft.DBUtility
{

    public class PubConstant
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString;
            }
        }
        /// <summary>
        /// 获取图片站点地址
        /// </summary>
        public static string PicSiteUrl
        {
            get
            {
                string _connectionString = "";
                try
                {
                    _connectionString = ConfigurationManager.AppSettings["PicSiteUrl"];
                }
                catch
                {
                    _connectionString = "http://www.aifmb.com/";
                }
                return _connectionString;
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }
        /// <summary>
        /// 得到web.config里配置项附件保存路径。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetAnnexSavePath(string configName)
        {
            return ConfigurationManager.AppSettings[configName];
        }

    }
}
