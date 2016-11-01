using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface,
                    AllowMultiple = true)]
    class Version : System.Attribute
    {

        private int versions;
        private int underVersion;

        public Version(int ver, int under)
        {
            this.Versions = ver;
            this.UnderVersion = under;
        }

        private int Versions
        {
            get
            {
                return this.versions;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive");
                }
                else
                {
                    this.versions = value;
                }
            }
        }

        private int UnderVersion
        {
            get
            {
                return this.underVersion;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive");
                }
                else
                {
                    this.underVersion = value;
                }
            }
        }

        public string VersionAttribute
        {
            get
            {
                return string.Format("{0}.{1}", this.Versions, this.UnderVersion);
            }
        }
    }
}