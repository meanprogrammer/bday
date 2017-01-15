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
        protected void Page_Load(object sender, EventArgs e)
        {
            //Add Data
            List<Member> members = new List<Member>();
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
            RandomHelper.GetRandomInteger();
        }
    }
}