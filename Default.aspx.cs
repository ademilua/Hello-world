using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AffectingDefaultValueWithIsPostBack
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
           if (!Page.IsPostBack)
           {
                nameTextBox.Text = "Your name pls";
                birthdayTextBox.Text = "m/d/yyyy";

            }

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            // name textbox takes a default value
            // Default value should be clear off once a postback occur as to output user input
            //Birthday textbox accept user input check if today is someones birthday or not.
            DateTime now = DateTime.Now;
            string dow =now.Day.ToString();
            int dow1 = int.Parse(dow);
            string mon = now.Month.ToString();
            int mon1 = int.Parse(mon);
            string yearnow = now.Year.ToString();

            DateTime birthday = DateTime.Parse(birthdayTextBox.Text);
            string bow = birthday.Day.ToString();
            int bow1 = int.Parse(bow);
            string Month = birthday.Month.ToString();
            int Month1 = int.Parse(Month);
            string year = birthday.Year.ToString();
            // string old = now.Subtract(birthday).ToString();
            int convertyearnow = int.Parse(yearnow);
            int convertyear = int.Parse(year);
            int old = convertyearnow - convertyear;
            string yourage = old.ToString();
            string dayold = (old > 7) ? "days" : "day"; // checks if the person is just newly born
            string suffix;
            int[] suffix2 = new int[3] { 11, 12, 13 };
            { 
            if (suffix2.Contains(old))
            {
                suffix = "th";
            }
            else if (old % 10 == 1)
            {
                suffix = "st";
            }
            else if (old % 10 == 2)
            {
                suffix = "nd";
            }
            else if (old % 10 == 3)
            {
                suffix = "rd";
            }
            else
            {
                suffix = "th";
            }
        
        }
         
             if ( mon1 == Month1 && dow1 == bow1 && convertyear < convertyearnow) 
            {
                resultLabel.Text = string.Format("Welcome {0} , Today {1},{2} is your birthday.<br>Congratulations on your {3}{4} birthday.", nameTextBox.Text, mon, dow,  yourage,suffix);
               
            }
           /* else if (dow != bow || mon != Month || convertyear < convertyearnow)
            {
                resultLabel.Text = string.Format("Welcome {0}, Today {1},{2},{3} is not your birthday", nameTextBox.Text, dow, mon, yearnow);
            }
            */
            else if (dow1 == bow1 && mon1 == Month1 && convertyear == convertyearnow)
            {
                resultLabel.Text = string.Format("Welcome {0}, Today {1},{2},{3} is your birthday and you are just {4} {5}", nameTextBox.Text,  mon, dow, yearnow, yourage, dayold);
            }
            else if ( convertyear > convertyearnow)
            {
                resultLabel.Text = string.Format("Oops your birthdate is greater than current,Today is {0}.<br> Did you forget your calendar", now.ToShortDateString());
            }
            
            else
            {
                resultLabel.Text = string.Format("Welcome {0} , Today {1},{2},{3} is not your birthday ", nameTextBox.Text,  mon, dow, yearnow);
            }
            
            
            // resultLabel1.Text = suffix;

        }
    }
}