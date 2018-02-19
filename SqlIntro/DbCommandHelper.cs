using System.Data;

namespace SqlIntro
{
    public static class DbCommandHelper
    {
        public static void AddParamWithValue(this IDbCommand cmd, string name, object value)
        {
            var param = cmd.CreateParameter();
            param.ParameterName = name;
            param.Value = value;
            cmd.Parameters.Add(param);
        }
    }
}
