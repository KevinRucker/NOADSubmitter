using System.IO;
using System.Reflection;
using NOADSubmitter.Framework;

namespace NOADSubmitter.Utility
{
    public class Common
    {
        public static BiStateYN ConvertToYN(string value)
        {
            switch (value.ToLower())
            {
                case "Yes":
                    return BiStateYN.Yes;
                case "No":
                    return BiStateYN.No;
                default:
                    return BiStateYN.NoSelection;
            }
        }

        public static BiStateTF ConvertToTF(string value)
        {
            switch (value.ToLower())
            {
                case "true":
                    return BiStateTF.True;
                case "false":
                    return BiStateTF.False;
                default:
                    return BiStateTF.NoSelection;
            }
        }

        public string GetEnumXmlValue(string value)
        {
            switch(value)
            {
                case "NoSelection":
                    return "No Selection";
                default:
                    return value.Replace("__", "-").Replace("_", " ");
            }
        }

        public static Stream GetEmbeddedResource(string path)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream(path);
        }
    }
}
