using System;

namespace Practice_form
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string email = inputEmail.Text;
            string id = inputID.Text;
            string description = inputDescription.InnerText;

            string gender;
            if (male.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            string skills = "";
            if (C.Checked)
            { skills += "C, "; }
            if (Cplus.Checked)
            { skills += "C++, "; }
            if (Csharp.Checked)
            { skills += "C#"; }


            displayName.Text = name;
            displayEmail.Text = email;
            displayID.Text = id;
            displayGender.Text = gender;
            displaySkills.Text = skills;
            displayDescription.Text = description;
        }
    }
}


