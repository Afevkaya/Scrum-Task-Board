using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.WebFormsUI
{
   public static class Control
    {
        public static string FazlaBoşluklarıSil(string ifade)
        {
            ifade = ifade.Trim();
            string yeniifade = string.Empty;

            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == ' ' && ifade[i + 1] == ' ')
                    continue;

                yeniifade += ifade[i];
            }
           
            return yeniifade;
        }
    }
}
