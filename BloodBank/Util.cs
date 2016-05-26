using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS408Project
{
    delegate void passDonors(List<Donors> donors);

    interface Util
    {
        void setDonors(List<Donors> donors);

    }
}
