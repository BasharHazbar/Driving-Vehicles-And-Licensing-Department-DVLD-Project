using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class ctrlLoginUserInformation : UserControl
    {
        public ctrlLoginUserInformation()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            clsUsers User = clsUsers.Find(UserID);
            if (User != null)
            {
                ctrlPersonCard.LoadPersonData(User.PersonID);
                ctrlUserCard.LoadUserData(User);
            }
        }

    }
}
