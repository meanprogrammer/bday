using Bday.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BdayWeb
{
    public partial class Default : System.Web.UI.Page
    {
        List<Member> members = new List<Member>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Add Data
            
            members.Add(new Member() { ID = 1, Name = "Stephen Sison" });
            members.Add(new Member() { ID = 2, Name = "Ghia Lagman" });
            members.Add(new Member() { ID = 3, Name = "Jho Amestoso" });
            members.Add(new Member() { ID = 4, Name = "Rina Dairimple" });
            members.Add(new Member() { ID = 5, Name = "Ms Ayala" });
            members.Add(new Member() { ID = 6, Name = "Francis Santos" });
            members.Add(new Member() { ID = 7, Name = "Valiant Dudan" });
            members.Add(new Member() { ID = 8, Name = "Clarissa Andrade" });
            members.Add(new Member() { ID = 9, Name = "Gwen Rebater" });
            members.Add(new Member() { ID = 10, Name = "Mikio Mukai" });
        }

        protected void RandomizeButton_Click(object sender, EventArgs e)
        {
            int firstNo = RandomHelper.GetRandomInteger(1, 10);
            var primary = members.Where(c => c.ID == firstNo).FirstOrDefault();
            if (primary != null)
            {
                this.TextBox1.Text = primary.Name;
            }

            int secNo = RandomHelper.GetRandomInteger(1, 10);
            while (secNo == firstNo)
            {
                secNo = RandomHelper.GetRandomInteger(1, 10);
            }

            var alalay = members.Where(c => c.ID == secNo).FirstOrDefault();
            if (alalay != null)
            {
                this.TextBox2.Text = alalay.Name;
            }
        }
    }
}