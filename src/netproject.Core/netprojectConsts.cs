using netproject.Debugging;

namespace netproject
{
    public class netprojectConsts
    {
        public const string LocalizationSourceName = "netproject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "466a3b1a4c0c4e46ae4793041798e088";
    }
}
