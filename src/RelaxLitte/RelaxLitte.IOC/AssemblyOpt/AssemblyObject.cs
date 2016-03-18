using System.Reflection;

namespace RelaxLittle.IOC.AssemblyOpt
{
    public class AssemblyObject
    {
        public AssemblyObject(string path)
        {
            Assembly.Load(path);
        }
    }
}
