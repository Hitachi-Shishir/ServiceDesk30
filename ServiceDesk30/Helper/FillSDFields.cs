﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
//using static iTextSharp.text.pdf.codec.TiffWriter;

/// <summary>
/// Summary description for FillSDFields
/// </summary>
namespace ServiceDesk30.Helper
{
    public class FillSDFields
    {

        public DataTable FillResolutionCustomer(string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddResolution ", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrgDeskRef", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "CustomerWise");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDCustomFieldsCustomer(string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spCustomFieldCntl", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrgRef", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "CustomerWise");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public DataTable FillSeverityWithCustomer(string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddSeverity", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrgDeskRef", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillPriorityWithCustomer(string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddPriority", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrgDeskRef", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "CustomerWise");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillStageCustomer(string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddStage", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrgDeskRef", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "CustomerWise");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserWiseApproval()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@" select * from SD_User_SRApproval", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserName()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@" select distinct  CONCAT(UserName,'-',LoginName) as 'Name',userid from SD_vUser", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillEmail()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select * from email", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillImpactDetails(string TicketID)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select * from SD_ChangeImpactDesc where Ticketref= '" + TicketID + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillRollOutDetails(string TicketID)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select * from SD_ChangeRollOutDesc where Ticketref= '" + TicketID + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillTaskAssocDetails(string TicketID)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select * from SD_ChangeTaskRef where Ticketref= '" + TicketID + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillPriority()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddPriority", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillKnowledgeResolution()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddKnowledgeBase", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillOrganization()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct  * from SD_OrgMaster  order by OrgName asc", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserEmailConfigdetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spEmailConfig", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillTicketNotes(string TicketNumber, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select * from SD_TicketNotes where Ticketref='" + TicketNumber + "' and organizationFK='" + OrgId + "' order by EditedDt desc", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillRequestType()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SD_spRequestType", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillChangeType()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SD_spChangeType", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillReasonForChange()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SD_spReasonType", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillEmailTemplate(string RequestType, string OrgID)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SD_spEmailTemplate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ReqRef", RequestType);
                        cmd.Parameters.AddWithValue("@OrgRef", OrgID);
                        cmd.Parameters.AddWithValue("@Option", "GetTemplate");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSeverity()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddSeverity", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillStatus()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddStatus", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillStage()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddStage", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDDetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct  * from vSDOrgDeskDef ", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillTechnicianDetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct  * from SD_vTechDetails order by FirstName asc", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserdetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct  * from SD_vUser  order by UserName asc", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserRole()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct  * from SD_Role  order by RoleName asc", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserScopedetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct  * from SD_UserScope  order by ScopeName asc", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable CheckUserForTechnician(long UserID)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select TechID,RefUserID,RequstTypeRef,CategoryFK from SD_Technician where RefUserID='" + UserID + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillResolution()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddResolution ", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserEcsleveldetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddUserEcslevel", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillCABdetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddCABApproval", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDODDNumberCustomFields(string ReqType, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowOddTxtCustomFld");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDODDNumberDropDownCustomFields(string ReqType, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowOddDdlCustomFld");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDODDNumberCustomFieldsForTech(string ReqType, string SDRole, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@SDRole", SDRole);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);

                        cmd.Parameters.AddWithValue("@Option", "ShowOddTxtCustomFldTech");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDODDNumberDropDownCustomFieldsForTech(string ReqType, string SDRole, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@SDRole", SDRole);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowOddDDlCustomFldTech");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDCustomFields()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spCustomFieldCntl", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDScope()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct UserScope from  SD_vUser", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDAccount(string scopename)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select distinct * from  SD_vUser where UserScope='" + scopename + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDEvenNumberCustomFields(string ReqType, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowEvenTxtCustomFld");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDEvenNumberDropDownCustomFields(string ReqType, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowEvenDdlCustomFld");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDEvenNumberCustomFieldsForTech(string ReqType, string SDRole, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@SDRole", SDRole);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowEvenTxtCustomFldTech");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDEvenNumberDropDownCustomFieldsForTech(string ReqType, string SDRole, string OrgId)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spSDCustomField_View", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DeskRef", ReqType);
                        cmd.Parameters.AddWithValue("@SDRole", SDRole);
                        cmd.Parameters.AddWithValue("@OrgId", OrgId);
                        cmd.Parameters.AddWithValue("@Option", "ShowEvenDDlCustomFldTech");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillUserSLAdetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddDeskSLA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillLocationWisePool()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddEngineerPool", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillCoverageSchdetails()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"select * from SD_CoverageSchedule", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillSDHoliday()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"SD_spAddHoliday", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Option", "see");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable FillCustomFieldValue(string fieldname)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"_sp_GetCustomFieldValue", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FieldName", fieldname);
                        cmd.Parameters.AddWithValue("@Option", "GetCustomFieldValue");
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                DataTable dt = new DataTable();
                                dt = ds.Tables[0];

                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}