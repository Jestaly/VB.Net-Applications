<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        midtermCSPanel = New Panel()
        saveCSMidtermButton = New Button()
        midtermCSGradeLabel = New Label()
        Label4 = New Label()
        examCSMidTextBox = New TextBox()
        Label3 = New Label()
        recitationCSMidTextBox = New TextBox()
        Label2 = New Label()
        caseStudyCSMidTextBox = New TextBox()
        labExerCSMidTextBox = New TextBox()
        Label1 = New Label()
        quizCSMidTextBox = New TextBox()
        clearCSMidtermButton = New Button()
        computeCSMidtermButton = New Button()
        midtermCSGrade = New Label()
        quizzesLabel = New Label()
        attendanceLabel = New Label()
        attCSMidTextBox = New TextBox()
        finalCSPanel = New Panel()
        saveCSFinalButton = New Button()
        finalCSGradeLabel = New Label()
        Label5 = New Label()
        examCSFinTextBox = New TextBox()
        Label7 = New Label()
        caseStudyCSFinTextBox = New TextBox()
        LabExerCSFinTextBox = New TextBox()
        Label8 = New Label()
        quizCSFinTextBox = New TextBox()
        clearCSFinalButton = New Button()
        computeCSFinalButton = New Button()
        finalCSGrade = New Label()
        Label10 = New Label()
        Label11 = New Label()
        attCSFinTextBox = New TextBox()
        studentNameTextBox = New TextBox()
        studentNumberLabel = New Label()
        studentNameLabel = New Label()
        semGrade = New Label()
        Label12 = New Label()
        studentNumberTextBox = New MaskedTextBox()
        courseLabel = New Label()
        studentCourseTextBox = New TextBox()
        sectionLabel = New Label()
        studentSectionTextBox = New TextBox()
        searchButton = New Button()
        midtermCSPanel.SuspendLayout()
        finalCSPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' midtermCSPanel
        ' 
        midtermCSPanel.BackColor = Color.FromArgb(CByte(16), CByte(55), CByte(92))
        midtermCSPanel.Controls.Add(saveCSMidtermButton)
        midtermCSPanel.Controls.Add(midtermCSGradeLabel)
        midtermCSPanel.Controls.Add(Label4)
        midtermCSPanel.Controls.Add(examCSMidTextBox)
        midtermCSPanel.Controls.Add(Label3)
        midtermCSPanel.Controls.Add(recitationCSMidTextBox)
        midtermCSPanel.Controls.Add(Label2)
        midtermCSPanel.Controls.Add(caseStudyCSMidTextBox)
        midtermCSPanel.Controls.Add(labExerCSMidTextBox)
        midtermCSPanel.Controls.Add(Label1)
        midtermCSPanel.Controls.Add(quizCSMidTextBox)
        midtermCSPanel.Controls.Add(clearCSMidtermButton)
        midtermCSPanel.Controls.Add(computeCSMidtermButton)
        midtermCSPanel.Controls.Add(midtermCSGrade)
        midtermCSPanel.Controls.Add(quizzesLabel)
        midtermCSPanel.Controls.Add(attendanceLabel)
        midtermCSPanel.Controls.Add(attCSMidTextBox)
        midtermCSPanel.Location = New Point(36, 181)
        midtermCSPanel.Name = "midtermCSPanel"
        midtermCSPanel.Size = New Size(954, 266)
        midtermCSPanel.TabIndex = 0
        midtermCSPanel.Visible = False
        ' 
        ' saveCSMidtermButton
        ' 
        saveCSMidtermButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveCSMidtermButton.Location = New Point(764, 208)
        saveCSMidtermButton.Name = "saveCSMidtermButton"
        saveCSMidtermButton.Size = New Size(79, 36)
        saveCSMidtermButton.TabIndex = 19
        saveCSMidtermButton.Text = "Save"
        saveCSMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermCSGradeLabel
        ' 
        midtermCSGradeLabel.AutoSize = True
        midtermCSGradeLabel.Font = New Font("Lucida Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midtermCSGradeLabel.ForeColor = SystemColors.ButtonHighlight
        midtermCSGradeLabel.Location = New Point(504, 41)
        midtermCSGradeLabel.Name = "midtermCSGradeLabel"
        midtermCSGradeLabel.Size = New Size(369, 39)
        midtermCSGradeLabel.TabIndex = 18
        midtermCSGradeLabel.Text = "MIDTERM GRADE 50%"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(278, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 23)
        Label4.TabIndex = 17
        Label4.Text = "Midterm Exam 30%"
        ' 
        ' examCSMidTextBox
        ' 
        examCSMidTextBox.Font = New Font("Lucida Sans", 12F)
        examCSMidTextBox.Location = New Point(278, 210)
        examCSMidTextBox.Name = "examCSMidTextBox"
        examCSMidTextBox.Size = New Size(184, 31)
        examCSMidTextBox.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(278, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 23)
        Label3.TabIndex = 15
        Label3.Text = "Recitation 10%"
        ' 
        ' recitationCSMidTextBox
        ' 
        recitationCSMidTextBox.Font = New Font("Lucida Sans", 12F)
        recitationCSMidTextBox.Location = New Point(278, 127)
        recitationCSMidTextBox.Name = "recitationCSMidTextBox"
        recitationCSMidTextBox.Size = New Size(184, 31)
        recitationCSMidTextBox.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(278, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 23)
        Label2.TabIndex = 13
        Label2.Text = "Case Study 20%"
        ' 
        ' caseStudyCSMidTextBox
        ' 
        caseStudyCSMidTextBox.Font = New Font("Lucida Sans", 12F)
        caseStudyCSMidTextBox.Location = New Point(278, 50)
        caseStudyCSMidTextBox.Name = "caseStudyCSMidTextBox"
        caseStudyCSMidTextBox.Size = New Size(184, 31)
        caseStudyCSMidTextBox.TabIndex = 12
        ' 
        ' labExerCSMidTextBox
        ' 
        labExerCSMidTextBox.Font = New Font("Lucida Sans", 12F)
        labExerCSMidTextBox.Location = New Point(52, 210)
        labExerCSMidTextBox.Name = "labExerCSMidTextBox"
        labExerCSMidTextBox.Size = New Size(184, 31)
        labExerCSMidTextBox.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(52, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 23)
        Label1.TabIndex = 10
        Label1.Text = "Lab Exercise 20%"
        ' 
        ' quizCSMidTextBox
        ' 
        quizCSMidTextBox.Font = New Font("Lucida Sans", 12F)
        quizCSMidTextBox.Location = New Point(52, 127)
        quizCSMidTextBox.Name = "quizCSMidTextBox"
        quizCSMidTextBox.Size = New Size(184, 31)
        quizCSMidTextBox.TabIndex = 9
        ' 
        ' clearCSMidtermButton
        ' 
        clearCSMidtermButton.Font = New Font("Lucida Sans", 12F)
        clearCSMidtermButton.Location = New Point(504, 156)
        clearCSMidtermButton.Name = "clearCSMidtermButton"
        clearCSMidtermButton.Size = New Size(169, 48)
        clearCSMidtermButton.TabIndex = 8
        clearCSMidtermButton.Text = "Clear"
        clearCSMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' computeCSMidtermButton
        ' 
        computeCSMidtermButton.Font = New Font("Lucida Sans", 12F)
        computeCSMidtermButton.Location = New Point(504, 91)
        computeCSMidtermButton.Name = "computeCSMidtermButton"
        computeCSMidtermButton.Size = New Size(169, 48)
        computeCSMidtermButton.TabIndex = 7
        computeCSMidtermButton.Text = "Compute"
        computeCSMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermCSGrade
        ' 
        midtermCSGrade.AutoSize = True
        midtermCSGrade.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        midtermCSGrade.BorderStyle = BorderStyle.Fixed3D
        midtermCSGrade.Font = New Font("Lucida Sans", 48F)
        midtermCSGrade.ForeColor = SystemColors.ButtonHighlight
        midtermCSGrade.Location = New Point(731, 98)
        midtermCSGrade.Name = "midtermCSGrade"
        midtermCSGrade.Size = New Size(143, 93)
        midtermCSGrade.TabIndex = 6
        midtermCSGrade.Text = "00"
        midtermCSGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quizzesLabel
        ' 
        quizzesLabel.AutoSize = True
        quizzesLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quizzesLabel.ForeColor = SystemColors.ButtonHighlight
        quizzesLabel.Location = New Point(52, 101)
        quizzesLabel.Name = "quizzesLabel"
        quizzesLabel.Size = New Size(134, 23)
        quizzesLabel.TabIndex = 4
        quizzesLabel.Text = "Quizzes 15%"
        ' 
        ' attendanceLabel
        ' 
        attendanceLabel.AutoSize = True
        attendanceLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        attendanceLabel.ForeColor = SystemColors.ButtonHighlight
        attendanceLabel.Location = New Point(52, 24)
        attendanceLabel.Name = "attendanceLabel"
        attendanceLabel.Size = New Size(155, 23)
        attendanceLabel.TabIndex = 3
        attendanceLabel.Text = "Attendance 5%"
        ' 
        ' attCSMidTextBox
        ' 
        attCSMidTextBox.Font = New Font("Lucida Sans", 12F)
        attCSMidTextBox.Location = New Point(52, 50)
        attCSMidTextBox.Name = "attCSMidTextBox"
        attCSMidTextBox.Size = New Size(184, 31)
        attCSMidTextBox.TabIndex = 0
        ' 
        ' finalCSPanel
        ' 
        finalCSPanel.BackColor = Color.FromArgb(CByte(16), CByte(55), CByte(92))
        finalCSPanel.Controls.Add(saveCSFinalButton)
        finalCSPanel.Controls.Add(finalCSGradeLabel)
        finalCSPanel.Controls.Add(Label5)
        finalCSPanel.Controls.Add(examCSFinTextBox)
        finalCSPanel.Controls.Add(Label7)
        finalCSPanel.Controls.Add(caseStudyCSFinTextBox)
        finalCSPanel.Controls.Add(LabExerCSFinTextBox)
        finalCSPanel.Controls.Add(Label8)
        finalCSPanel.Controls.Add(quizCSFinTextBox)
        finalCSPanel.Controls.Add(clearCSFinalButton)
        finalCSPanel.Controls.Add(computeCSFinalButton)
        finalCSPanel.Controls.Add(finalCSGrade)
        finalCSPanel.Controls.Add(Label10)
        finalCSPanel.Controls.Add(Label11)
        finalCSPanel.Controls.Add(attCSFinTextBox)
        finalCSPanel.Location = New Point(36, 462)
        finalCSPanel.Name = "finalCSPanel"
        finalCSPanel.Size = New Size(954, 276)
        finalCSPanel.TabIndex = 1
        finalCSPanel.Visible = False
        ' 
        ' saveCSFinalButton
        ' 
        saveCSFinalButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveCSFinalButton.Location = New Point(764, 217)
        saveCSFinalButton.Name = "saveCSFinalButton"
        saveCSFinalButton.Size = New Size(79, 36)
        saveCSFinalButton.TabIndex = 20
        saveCSFinalButton.Text = "Save"
        saveCSFinalButton.UseVisualStyleBackColor = True
        ' 
        ' finalCSGradeLabel
        ' 
        finalCSGradeLabel.AutoSize = True
        finalCSGradeLabel.Font = New Font("Lucida Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        finalCSGradeLabel.ForeColor = SystemColors.ButtonHighlight
        finalCSGradeLabel.Location = New Point(533, 37)
        finalCSGradeLabel.Name = "finalCSGradeLabel"
        finalCSGradeLabel.Size = New Size(310, 39)
        finalCSGradeLabel.TabIndex = 19
        finalCSGradeLabel.Text = "FINAL GRADE 50%"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 12F)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(278, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 23)
        Label5.TabIndex = 32
        Label5.Text = "Final Exam 30%"
        ' 
        ' examCSFinTextBox
        ' 
        examCSFinTextBox.Font = New Font("Lucida Sans", 12F)
        examCSFinTextBox.Location = New Point(278, 139)
        examCSFinTextBox.Name = "examCSFinTextBox"
        examCSFinTextBox.Size = New Size(184, 31)
        examCSFinTextBox.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(278, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(228, 21)
        Label7.TabIndex = 28
        Label7.Text = "Project / Case Study 30%"
        ' 
        ' caseStudyCSFinTextBox
        ' 
        caseStudyCSFinTextBox.Font = New Font("Lucida Sans", 12F)
        caseStudyCSFinTextBox.Location = New Point(278, 62)
        caseStudyCSFinTextBox.Name = "caseStudyCSFinTextBox"
        caseStudyCSFinTextBox.Size = New Size(184, 31)
        caseStudyCSFinTextBox.TabIndex = 27
        ' 
        ' LabExerCSFinTextBox
        ' 
        LabExerCSFinTextBox.Font = New Font("Lucida Sans", 12F)
        LabExerCSFinTextBox.Location = New Point(52, 222)
        LabExerCSFinTextBox.Name = "LabExerCSFinTextBox"
        LabExerCSFinTextBox.Size = New Size(184, 31)
        LabExerCSFinTextBox.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(52, 196)
        Label8.Name = "Label8"
        Label8.Size = New Size(179, 23)
        Label8.TabIndex = 25
        Label8.Text = "Lab Exercise 20%"
        ' 
        ' quizCSFinTextBox
        ' 
        quizCSFinTextBox.Font = New Font("Lucida Sans", 12F)
        quizCSFinTextBox.Location = New Point(52, 139)
        quizCSFinTextBox.Name = "quizCSFinTextBox"
        quizCSFinTextBox.Size = New Size(184, 31)
        quizCSFinTextBox.TabIndex = 24
        ' 
        ' clearCSFinalButton
        ' 
        clearCSFinalButton.Font = New Font("Lucida Sans", 12F)
        clearCSFinalButton.Location = New Point(504, 166)
        clearCSFinalButton.Name = "clearCSFinalButton"
        clearCSFinalButton.Size = New Size(169, 48)
        clearCSFinalButton.TabIndex = 23
        clearCSFinalButton.Text = "Clear"
        clearCSFinalButton.UseVisualStyleBackColor = True
        ' 
        ' computeCSFinalButton
        ' 
        computeCSFinalButton.Font = New Font("Lucida Sans", 12F)
        computeCSFinalButton.Location = New Point(504, 101)
        computeCSFinalButton.Name = "computeCSFinalButton"
        computeCSFinalButton.Size = New Size(169, 48)
        computeCSFinalButton.TabIndex = 22
        computeCSFinalButton.Text = "Compute"
        computeCSFinalButton.UseVisualStyleBackColor = True
        ' 
        ' finalCSGrade
        ' 
        finalCSGrade.AutoSize = True
        finalCSGrade.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        finalCSGrade.BorderStyle = BorderStyle.Fixed3D
        finalCSGrade.Font = New Font("Lucida Sans", 48F)
        finalCSGrade.ForeColor = SystemColors.ButtonHighlight
        finalCSGrade.Location = New Point(731, 110)
        finalCSGrade.Name = "finalCSGrade"
        finalCSGrade.Size = New Size(143, 93)
        finalCSGrade.TabIndex = 21
        finalCSGrade.Text = "00"
        finalCSGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans", 12F)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(52, 113)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 23)
        Label10.TabIndex = 20
        Label10.Text = "Quizzes 15%"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans", 12F)
        Label11.ForeColor = SystemColors.ButtonHighlight
        Label11.Location = New Point(52, 37)
        Label11.Name = "Label11"
        Label11.Size = New Size(155, 23)
        Label11.TabIndex = 19
        Label11.Text = "Attendance 5%"
        ' 
        ' attCSFinTextBox
        ' 
        attCSFinTextBox.Font = New Font("Lucida Sans", 12F)
        attCSFinTextBox.Location = New Point(52, 62)
        attCSFinTextBox.Name = "attCSFinTextBox"
        attCSFinTextBox.Size = New Size(184, 31)
        attCSFinTextBox.TabIndex = 18
        ' 
        ' studentNameTextBox
        ' 
        studentNameTextBox.Enabled = False
        studentNameTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNameTextBox.Location = New Point(490, 63)
        studentNameTextBox.Name = "studentNameTextBox"
        studentNameTextBox.Size = New Size(300, 31)
        studentNameTextBox.TabIndex = 2
        ' 
        ' studentNumberLabel
        ' 
        studentNumberLabel.AutoSize = True
        studentNumberLabel.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNumberLabel.ForeColor = SystemColors.ButtonHighlight
        studentNumberLabel.Location = New Point(285, 39)
        studentNumberLabel.Name = "studentNumberLabel"
        studentNumberLabel.Size = New Size(144, 19)
        studentNumberLabel.TabIndex = 3
        studentNumberLabel.Text = "Student Number"
        ' 
        ' studentNameLabel
        ' 
        studentNameLabel.AutoSize = True
        studentNameLabel.Font = New Font("Lucida Sans", 10.8F)
        studentNameLabel.ForeColor = SystemColors.ButtonHighlight
        studentNameLabel.Location = New Point(490, 39)
        studentNameLabel.Name = "studentNameLabel"
        studentNameLabel.Size = New Size(136, 21)
        studentNameLabel.TabIndex = 4
        studentNameLabel.Text = "Student Name"
        ' 
        ' semGrade
        ' 
        semGrade.AutoSize = True
        semGrade.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        semGrade.BorderStyle = BorderStyle.Fixed3D
        semGrade.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        semGrade.ForeColor = SystemColors.ButtonHighlight
        semGrade.Location = New Point(122, 26)
        semGrade.Name = "semGrade"
        semGrade.Size = New Size(118, 78)
        semGrade.TabIndex = 9
        semGrade.Text = "00"
        semGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans", 10.8F)
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(104, 113)
        Label12.Name = "Label12"
        Label12.Size = New Size(155, 21)
        Label12.TabIndex = 10
        Label12.Text = "Semestral Grade"
        ' 
        ' studentNumberTextBox
        ' 
        studentNumberTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNumberTextBox.Location = New Point(285, 63)
        studentNumberTextBox.Mask = "00-00000"
        studentNumberTextBox.Name = "studentNumberTextBox"
        studentNumberTextBox.PromptChar = "X"c
        studentNumberTextBox.Size = New Size(158, 31)
        studentNumberTextBox.TabIndex = 11
        studentNumberTextBox.ValidatingType = GetType(Date)
        ' 
        ' courseLabel
        ' 
        courseLabel.AutoSize = True
        courseLabel.Font = New Font("Lucida Sans", 10.8F)
        courseLabel.ForeColor = SystemColors.ButtonHighlight
        courseLabel.Location = New Point(490, 107)
        courseLabel.Name = "courseLabel"
        courseLabel.Size = New Size(71, 21)
        courseLabel.TabIndex = 13
        courseLabel.Text = "Course"
        ' 
        ' studentCourseTextBox
        ' 
        studentCourseTextBox.Enabled = False
        studentCourseTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentCourseTextBox.Location = New Point(490, 131)
        studentCourseTextBox.Name = "studentCourseTextBox"
        studentCourseTextBox.Size = New Size(156, 31)
        studentCourseTextBox.TabIndex = 12
        ' 
        ' sectionLabel
        ' 
        sectionLabel.AutoSize = True
        sectionLabel.Font = New Font("Lucida Sans", 10.8F)
        sectionLabel.ForeColor = SystemColors.ButtonHighlight
        sectionLabel.Location = New Point(652, 107)
        sectionLabel.Name = "sectionLabel"
        sectionLabel.Size = New Size(74, 21)
        sectionLabel.TabIndex = 15
        sectionLabel.Text = "Section"
        ' 
        ' studentSectionTextBox
        ' 
        studentSectionTextBox.Enabled = False
        studentSectionTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentSectionTextBox.Location = New Point(652, 131)
        studentSectionTextBox.Name = "studentSectionTextBox"
        studentSectionTextBox.Size = New Size(138, 31)
        studentSectionTextBox.TabIndex = 14
        ' 
        ' searchButton
        ' 
        searchButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.Location = New Point(325, 105)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(82, 29)
        searchButton.TabIndex = 16
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' GradeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(49), CByte(49))
        ClientSize = New Size(1030, 772)
        Controls.Add(searchButton)
        Controls.Add(sectionLabel)
        Controls.Add(studentSectionTextBox)
        Controls.Add(courseLabel)
        Controls.Add(studentCourseTextBox)
        Controls.Add(studentNumberTextBox)
        Controls.Add(Label12)
        Controls.Add(semGrade)
        Controls.Add(studentNameLabel)
        Controls.Add(studentNumberLabel)
        Controls.Add(studentNameTextBox)
        Controls.Add(finalCSPanel)
        Controls.Add(midtermCSPanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "GradeForm"
        Text = "Grade Form"
        midtermCSPanel.ResumeLayout(False)
        midtermCSPanel.PerformLayout()
        finalCSPanel.ResumeLayout(False)
        finalCSPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents midtermCSPanel As Panel
    Friend WithEvents finalCSPanel As Panel
    Friend WithEvents studentNameTextBox As TextBox
    Friend WithEvents studentNumberLabel As Label
    Friend WithEvents studentNameLabel As Label
    Friend WithEvents attCSMidTextBox As TextBox
    Friend WithEvents quizzesLabel As Label
    Friend WithEvents attendanceLabel As Label
    Friend WithEvents midtermCSGrade As Label
    Friend WithEvents clearCSMidtermButton As Button
    Friend WithEvents computeCSMidtermButton As Button
    Friend WithEvents semGrade As Label
    Friend WithEvents quizCSMidTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents caseStudyCSMidTextBox As TextBox
    Friend WithEvents labExerCSMidTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents examCSMidTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents recitationCSMidTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents examCSFinTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents caseStudyCSFinTextBox As TextBox
    Friend WithEvents LabExerCSFinTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents quizCSFinTextBox As TextBox
    Friend WithEvents clearCSFinalButton As Button
    Friend WithEvents computeCSFinalButton As Button
    Friend WithEvents finalCSGrade As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents attCSFinTextBox As TextBox
    Friend WithEvents midtermCSGradeLabel As Label
    Friend WithEvents finalCSGradeLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents studentNumberTextBox As MaskedTextBox
    Friend WithEvents saveCSMidtermButton As Button
    Friend WithEvents saveCSFinalButton As Button
    Friend WithEvents courseLabel As Label
    Friend WithEvents studentCourseTextBox As TextBox
    Friend WithEvents sectionLabel As Label
    Friend WithEvents studentSectionTextBox As TextBox
    Friend WithEvents searchButton As Button
End Class
