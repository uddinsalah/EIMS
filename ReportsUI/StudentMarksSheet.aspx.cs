﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

public partial class ReportsUI_StudentMarksSheet : Page
{
    private SWISDataContext db = new SWISDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void showButton_Click(object sender, EventArgs e)
    {
        var report = new ReportDocument();
        //if (studentIdTextBox.Text != "")
        //{
        //    tbl_Present_class pcl = db.tbl_Present_classes.FirstOrDefault(x => x.VarStudentID == studentIdTextBox.Text);
        //    Class cls = db.Classes.FirstOrDefault(x => x.VarClassID == pcl.VarClassID);
        //    if (cls != null && cls.ClassType == 2)
        //    {

        //        report.Load(Server.MapPath("~/Reports/SPC_A_Level_Class.rpt"));
        //        StudentMarksSheet.ReportSource = report;
        //        //StudentMarksSheet.DataBind();
        //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarStudentID} ='" +
        //                                                               studentIdTextBox.Text +
        //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
        //        StudentMarksSheet.RefreshReport();
        //    }
        //    else if (cls != null && cls.ClassType == 1)
        //    {
        //        report.Load(Server.MapPath("~/Reports/SPC_O_Level_Class.rpt"));
        //        StudentMarksSheet.ReportSource = report;
        //        // StudentMarksSheet.DataBind();
        //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarStudentID} ='" +
        //                                                               studentIdTextBox.Text +
        //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
        //        StudentMarksSheet.RefreshReport();
        //    }
        //    else
        //    {
        //        report.Load(Server.MapPath("~/Reports/SPCJuniorClass.rpt"));
        //        StudentMarksSheet.ReportSource = report;
        //        //StudentMarksSheet.DataBind();
        //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarStudentID} ='" +
        //                                                               studentIdTextBox.Text +
        //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
        //        StudentMarksSheet.RefreshReport();
        //    }

        //}
        if (classDropDownList.SelectedValue != "0")
        {
            //Class cls = db.Classes.FirstOrDefault(x => x.VarClassID == classDropDownList.SelectedValue);
            //if (cls != null && cls.ClassType == 2)
            //{
            if (subjectDropDownList.SelectedValue != "" && sectionDropDownList.SelectedValue == "0" &&
                unitcodeDropDownList.SelectedValue == "")
            {
                report.Load(Server.MapPath("~/Reports/SubjectWiseMarksSheet_A_Lavel.rpt"));
                StudentMarksSheet.ReportSource = report;
                //StudentMarksSheet.DataBind();
                StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
                                                     classDropDownList.SelectedValue + "'and {tbl_ExamMarks.ExamCode}='" +
                                                     examNameDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.VarSubjectCode}='" +
                                                     subjectDropDownList.SelectedValue +
                                                     "'and {tbl_Present_class.Status}='" + "P" + "'";
                StudentMarksSheet.RefreshReport();
            }
            else if (subjectDropDownList.SelectedValue != "" && sectionDropDownList.SelectedValue == "0" &&
                     unitcodeDropDownList.SelectedValue != "")
            {
                report.Load(Server.MapPath("~/Reports/SubjectWiseMarksSheet_A_Lavel.rpt"));
                StudentMarksSheet.ReportSource = report;
                //StudentMarksSheet.DataBind();
                StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
                                                     classDropDownList.SelectedValue + "'and {tbl_ExamMarks.ExamCode}='" +
                                                     examNameDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.VarSubjectCode}='" +
                                                     subjectDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.UnitCode}='" +
                                                     unitcodeDropDownList.SelectedValue +
                                                     "'and {tbl_Present_class.Status}='" + "P" + "'";
                StudentMarksSheet.RefreshReport();
            }
            else if (subjectDropDownList.SelectedValue != "" && sectionDropDownList.SelectedValue != "0" &&
                     unitcodeDropDownList.SelectedValue == "")
            {
                report.Load(Server.MapPath("~/Reports/SubjectWiseMarksSheet_A_Lavel.rpt"));
                StudentMarksSheet.ReportSource = report;
                //StudentMarksSheet.DataBind();
                StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
                                                     classDropDownList.SelectedValue + "'and {tbl_ExamMarks.ExamCode}='" +
                                                     examNameDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.VarSubjectCode}='" +
                                                     subjectDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.VarSection}='" +
                                                     sectionDropDownList.SelectedValue +
                                                     "'and {tbl_Present_class.Status}='" + "P" + "'";
                StudentMarksSheet.RefreshReport();
            }
            else if (subjectDropDownList.SelectedValue != "" && sectionDropDownList.SelectedValue != "0" &&
                     unitcodeDropDownList.SelectedValue != "")
            {
                report.Load(Server.MapPath("~/Reports/SubjectWiseMarksSheet_A_Lavel.rpt"));
                StudentMarksSheet.ReportSource = report;
                //StudentMarksSheet.DataBind();
                StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
                                                     classDropDownList.SelectedValue + "'and {tbl_ExamMarks.ExamCode}='" +
                                                     examNameDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.VarSubjectCode}='" +
                                                     subjectDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.VarSection}='" +
                                                     sectionDropDownList.SelectedValue +
                                                     "'and {tbl_ExamMarks.UnitCode}='" +
                                                     unitcodeDropDownList.SelectedValue +
                                                     "'and {tbl_Present_class.Status}='" + "P" + "'";
                StudentMarksSheet.RefreshReport();
            }

            //    else if (sessionDropDownList.SelectedValue != "" &&
            //             classDropDownList.SelectedValue != "0" && sectionDropDownList.SelectedValue != "0")
            //    {
            //        report.Load(Server.MapPath("~/Reports/SPC_A_Level_Class.rpt"));
            //        StudentMarksSheet.ReportSource = report;
            //        //StudentMarksSheet.DataBind();
            //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
            //                                                               classDropDownList.SelectedValue + "'and {tbl_Present_class.VarSection}='" + sectionDropDownList.SelectedValue +
            //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
            //        StudentMarksSheet.RefreshReport();
            //    }
            //}
            //else if (cls != null && cls.ClassType == 1)
            //{
            //    if (sessionDropDownList.SelectedValue != "" && sectionDropDownList.SelectedValue == "0" &&
            //    classDropDownList.SelectedValue != "0")
            //    {
            //        report.Load(Server.MapPath("~/Reports/SPC_O_Level_Class.rpt"));
            //        StudentMarksSheet.ReportSource = report;
            //        //StudentMarksSheet.DataBind();
            //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
            //                                                               classDropDownList.SelectedValue +
            //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
            //        StudentMarksSheet.RefreshReport();
            //    }
            //    else if (sessionDropDownList.SelectedValue != "" &&
            //             classDropDownList.SelectedValue != "0" && sectionDropDownList.SelectedValue != "0")
            //    {
            //        report.Load(Server.MapPath("~/Reports/SPC_O_Level_Class.rpt"));
            //        StudentMarksSheet.ReportSource = report;
            //        //StudentMarksSheet.DataBind();
            //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
            //                                                               classDropDownList.SelectedValue + "'and {tbl_Present_class.VarSection}='" + sectionDropDownList.SelectedValue +
            //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
            //        StudentMarksSheet.RefreshReport();
            //    }
            //}
            //else
            //{
            //    if (sessionDropDownList.SelectedValue != "" && sectionDropDownList.SelectedValue == "0" &&
            //    classDropDownList.SelectedValue != "0")
            //    {
            //        report.Load(Server.MapPath("~/Reports/SPCJuniorClass.rpt"));
            //        StudentMarksSheet.ReportSource = report;
            //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
            //                                                               classDropDownList.SelectedValue +
            //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
            //        StudentMarksSheet.RefreshReport();
            //    }
            //    else if (sessionDropDownList.SelectedValue != "" &&
            //             classDropDownList.SelectedValue != "0" && sectionDropDownList.SelectedValue != "0")
            //    {
            //        report.Load(Server.MapPath("~/Reports/SPCJuniorClass.rpt"));
            //        StudentMarksSheet.ReportSource = report;
            //        StudentMarksSheet.SelectionFormula = "{tbl_Present_class.VarClassId} ='" +
            //                                                               classDropDownList.SelectedValue + "'and {tbl_Present_class.VarSection}='" + sectionDropDownList.SelectedValue +
            //                                                               "'and {tbl_Present_class.Status}='" + "P" + "'";
            //        StudentMarksSheet.RefreshReport();
            //    }
            //}
        }
    }

    protected void classDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        sectionDropDownList.Items.Clear();
        sectionDropDownList.Items.Insert(0, new ListItem("--Select--", "0"));
    }
}