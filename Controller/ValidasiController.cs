using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan11.Controller
{
    internal class ValidasiController
    {
        public bool valId(string id)
        {
            for(int a=0; a <= id.Length; a++)
            {
                if (id[0] == ' ')
                {
                    MessageBox.Show("Input Id Failed","add Id",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }return true;
        }
        public bool valName(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[name.Length - 1] == ' ' || name[a] == '-' ||
                    name[a] == '/' || name[a] == '\\' || name[a] == '?' || name[a] == '!' ||
                    name[a] == '@' || name[a] == '#' || name[a] == '$' || name[a] == '%' ||
                    name[a] == '^' || name[a] == '&' || name[a] == '*' || name[a] == '(' ||
                    name[a] == ')' || name[a] == '`' || name[a] == '~' || name[a] == '+' ||
                    name[a] == '=' || name[a] == '[' || name[a] == ']' || name[a] == '{' ||
                    name[a] == '}' || name[a] == ';' || name[a] == '\'' || name[a] == ':' ||
                    name[a] == '\"' || name[a] == ',' || name[a] == '.' || name[a] == '/' ||
                    name[a] == '>' || name[a] == '<' || name[a] == '|')
                {
                    MessageBox.Show("Input Name failed", "add name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

    }
}
