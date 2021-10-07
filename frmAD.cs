﻿using System;
using System.Windows.Forms;

using System.Security.Permissions;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using SearchScope = System.DirectoryServices.Protocols.SearchScope;



//[assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution = true)]
//[assembly: DirectoryServicesPermission(SecurityAction.RequestMinimum)]

namespace ActiveDirectory
{
    public partial class frmAD : Form
    {
        public DirectorySearcher dirSearch = null;

        static string username = "Suman Saha";
        static string password = "yamuna@890";
        static string domain = "wipro.com";

        public frmAD()
        {
            InitializeComponent();
        }
/*
        private void frmAD_Load(object sender, EventArgs e)
        {
            
           public string domain = GetSystemDomain();
            if (domain == null)
            {
                domain = "wipro.com";
            }
        }

        private string GetSystemDomain()
        {
            try
            {
                return Domain.GetComputerDomain().ToString().ToLower();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return string.Empty;
            }
        } */

        private void GetUserInformation(string username, string passowrd, string domain)
        {
            Cursor.Current = Cursors.WaitCursor;

            pnlblock1.BringToFront();
            pnlblock1.Visible = true;

            SearchResult rs = null;
            if (txtSearchUser.Text.Trim().IndexOf("@") > 0)
                rs = SearchUserByEmail(GetDirectorySearcher(username, passowrd, domain), txtSearchUser.Text.Trim());
            else
                rs = SearchUserByUserName(GetDirectorySearcher(username, passowrd, domain), txtSearchUser.Text.Trim());

            if (rs != null)
            {
                ShowUserInformation(rs);
            }
            else
            {
                MessageBox.Show("User not found!!!", "Search Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowUserInformation(SearchResult rs)
        {
            Cursor.Current = Cursors.Default;
            pnlblock2.SendToBack();
            pnlblock2.Visible = false;

            if (rs.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                lblUsernameDisplay.Text = rs.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["givenName"].Value != null)
                lblFirstname.Text = rs.GetDirectoryEntry().Properties["givenName"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["employeeID"].Value != null)
                lblEmployeeID.Text = rs.GetDirectoryEntry().Properties["employeeID"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["sn"].Value != null)
                lblLastName.Text = rs.GetDirectoryEntry().Properties["sn"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["mail"].Value != null)
                lblEmailId.Text = rs.GetDirectoryEntry().Properties["mail"].Value.ToString();
            /*
            if (rs.GetDirectoryEntry().Properties["title"].Value != null)
                lblTitle.Text = "Title : " + rs.GetDirectoryEntry().Properties["title"].Value.ToString();
            
            if (rs.GetDirectoryEntry().Properties["company"].Value != null)
                lblCompany.Text = "Company : " + rs.GetDirectoryEntry().Properties["company"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["l"].Value != null)
                lblCity.Text = "City : " + rs.GetDirectoryEntry().Properties["l"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["st"].Value != null)
                lblState.Text = "State : " + rs.GetDirectoryEntry().Properties["st"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["co"].Value != null)
                lblCountry.Text = "Country : " + rs.GetDirectoryEntry().Properties["co"].Value.ToString();

            if (rs.GetDirectoryEntry().Properties["postalCode"].Value != null)
                lblPostal.Text = "Postal Code : " + rs.GetDirectoryEntry().Properties["postalCode"].Value.ToString();
*/
            if (rs.GetDirectoryEntry().Properties["mobile"].Value != null)
                lblTelephon.Text = rs.GetDirectoryEntry().Properties["mobile"].Value.ToString();
        
        }

        private DirectorySearcher GetDirectorySearcher(string username, string password, string domain)
        {
            if (dirSearch == null)
            {
                try
                {
                    dirSearch = new DirectorySearcher(
                      //new DirectoryEntry("LDAP://" + domain)); //Legacy Now with 636 enabled
                    new DirectoryEntry("LDAP://blr-ec-dc07.wipro.com:636" + null, null, null, AuthenticationTypes.SecureSocketsLayer | AuthenticationTypes.Secure));
                    //Searching LDAP through DirectoryEntry  Object 

                    /*
                    LdapConnection dirSearch = new LdapConnection(new LdapDirectoryIdentifier("blr-ec-dc07.wipro.com", 636));
                    dirSearch.SessionOptions.SecureSocketLayer = true;
                    dirSearch.SessionOptions.VerifyServerCertificate = new VerifyServerCertificateCallback(ServerCallBack);
                    dirSearch.Credential = new NetworkCredential("CN=" + username + ",CN=Users,DC=wipro,DC=com", password, "CN=Users,DC=wipro,DC=com");
                    dirSearch.AuthType = AuthType.Basic;
                    dirSearch.Bind();
                    */

                }
                catch (DirectoryServicesCOMException e) //System.DirectoryServices.Protocols.LdapException 
                {
                    MessageBox.Show("Connection Credential is Wrong!!!, please Check.", "Erro Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Message.ToString();
                }
                return dirSearch;
            }
            else
            {
                return dirSearch;
            }
        }

        private bool ServerCallBack(LdapConnection dirSearch, X509Certificate certificate)
        {
            return true;
        }
        private SearchResult SearchUserByUserName(DirectorySearcher ds, string employeeID)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(employeeID=" + employeeID + "))";

            ds.SearchScope = (System.DirectoryServices.SearchScope)SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
                return userObject;
            else
                return null;
        }

        private SearchResult SearchUserByEmail(DirectorySearcher ds, string email)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(mail=" + email + "))";

            ds.SearchScope = (System.DirectoryServices.SearchScope)SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
                return userObject;
            else
                return null;
        }


        private void btnSearchUserName_Click(object sender, EventArgs e)
        {


                if (txtSearchUser.Text.Trim().Length != 0)
            {
                GetUserInformation(username, password, domain);
            }
            else
            {
                MessageBox.Show("Please enter all required inputs.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblEmployeeID.Text);
        }

        private void TxtSearchUser_KeyPress(object sender, KeyPressEventArgs e) //Enter Key Action

        { 

        if (e.KeyChar == (int) Keys.Enter)
            {
                if (txtSearchUser.Text.Trim().Length != 0)
                {
                    GetUserInformation(username, password, domain);
    }
                else
                {
                    MessageBox.Show("Please enter all required inputs.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}