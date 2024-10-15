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
        midtermPanel = New Panel()
        setPercentageMidButton = New Button()
        saveMidtermButton = New Button()
        midtermPercLabel = New Label()
        examMidLabel = New Label()
        examMidTextBox = New TextBox()
        recitationMidLabel = New Label()
        recitationMidTextBox = New TextBox()
        caseStudyMidLabel = New Label()
        caseStudyMidTextBox = New TextBox()
        labExerMidTextBox = New TextBox()
        labExerMidLabel = New Label()
        quizMidTextBox = New TextBox()
        clearMidtermButton = New Button()
        computeMidtermButton = New Button()
        midtermGradeLabel = New Label()
        quizMidLabel = New Label()
        attendanceMidLabel = New Label()
        attMidTextBox = New TextBox()
        finalPanel = New Panel()
        setPercentageFinalButton = New Button()
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
        nullMidtermPanel = New Panel()
        nullRecordPanel1 = New Panel()
        nullRecordMidterm = New Label()
        nullFinalPanel = New Panel()
        nullRecordPanel2 = New Panel()
        nullRecordFinal = New Label()
        midtermPanel.SuspendLayout()
        finalPanel.SuspendLayout()
        nullMidtermPanel.SuspendLayout()
        nullRecordPanel1.SuspendLayout()
        nullFinalPanel.SuspendLayout()
        nullRecordPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' midtermPanel
        ' 
        midtermPanel.BackColor = Color.FromArgb(CByte(16), CByte(55), CByte(92))
        midtermPanel.Controls.Add(setPercentageMidButton)
        midtermPanel.Controls.Add(saveMidtermButton)
        midtermPanel.Controls.Add(midtermPercLabel)
        midtermPanel.Controls.Add(examMidLabel)
        midtermPanel.Controls.Add(examMidTextBox)
        midtermPanel.Controls.Add(recitationMidLabel)
        midtermPanel.Controls.Add(recitationMidTextBox)
        midtermPanel.Controls.Add(caseStudyMidLabel)
        midtermPanel.Controls.Add(caseStudyMidTextBox)
        midtermPanel.Controls.Add(labExerMidTextBox)
        midtermPanel.Controls.Add(labExerMidLabel)
        midtermPanel.Controls.Add(quizMidTextBox)
        midtermPanel.Controls.Add(clearMidtermButton)
        midtermPanel.Controls.Add(computeMidtermButton)
        midtermPanel.Controls.Add(midtermGradeLabel)
        midtermPanel.Controls.Add(quizMidLabel)
        midtermPanel.Controls.Add(attendanceMidLabel)
        midtermPanel.Controls.Add(attMidTextBox)
        midtermPanel.Location = New Point(36, 181)
        midtermPanel.Name = "midtermPanel"
        midtermPanel.Size = New Size(954, 266)
        midtermPanel.TabIndex = 0
        midtermPanel.Visible = False
        ' 
        ' setPercentageMidButton
        ' 
        setPercentageMidButton.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        setPercentageMidButton.Location = New Point(504, 183)
        setPercentageMidButton.Name = "setPercentageMidButton"
        setPercentageMidButton.Size = New Size(169, 48)
        setPercentageMidButton.TabIndex = 20
        setPercentageMidButton.Text = "Set Percentage"
        setPercentageMidButton.UseVisualStyleBackColor = True
        ' 
        ' saveMidtermButton
        ' 
        saveMidtermButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveMidtermButton.Location = New Point(846, 19)
        saveMidtermButton.Name = "saveMidtermButton"
        saveMidtermButton.Size = New Size(79, 36)
        saveMidtermButton.TabIndex = 19
        saveMidtermButton.Text = "Save"
        saveMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermPercLabel
        ' 
        midtermPercLabel.AutoSize = True
        midtermPercLabel.Font = New Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midtermPercLabel.ForeColor = SystemColors.ButtonHighlight
        midtermPercLabel.Location = New Point(533, 22)
        midtermPercLabel.Name = "midtermPercLabel"
        midtermPercLabel.Size = New Size(253, 26)
        midtermPercLabel.TabIndex = 18
        midtermPercLabel.Text = "MIDTERM GRADE: 0%"
        ' 
        ' examMidLabel
        ' 
        examMidLabel.AutoSize = True
        examMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        examMidLabel.ForeColor = SystemColors.ButtonHighlight
        examMidLabel.Location = New Point(278, 184)
        examMidLabel.Name = "examMidLabel"
        examMidLabel.Size = New Size(171, 23)
        examMidLabel.TabIndex = 17
        examMidLabel.Text = "Midterm Exam %"
        ' 
        ' examMidTextBox
        ' 
        examMidTextBox.Font = New Font("Lucida Sans", 12F)
        examMidTextBox.Location = New Point(278, 210)
        examMidTextBox.Name = "examMidTextBox"
        examMidTextBox.Size = New Size(184, 31)
        examMidTextBox.TabIndex = 16
        ' 
        ' recitationMidLabel
        ' 
        recitationMidLabel.AutoSize = True
        recitationMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        recitationMidLabel.ForeColor = SystemColors.ButtonHighlight
        recitationMidLabel.Location = New Point(278, 101)
        recitationMidLabel.Name = "recitationMidLabel"
        recitationMidLabel.Size = New Size(128, 23)
        recitationMidLabel.TabIndex = 15
        recitationMidLabel.Text = "Recitation %"
        ' 
        ' recitationMidTextBox
        ' 
        recitationMidTextBox.Font = New Font("Lucida Sans", 12F)
        recitationMidTextBox.Location = New Point(278, 127)
        recitationMidTextBox.Name = "recitationMidTextBox"
        recitationMidTextBox.Size = New Size(184, 31)
        recitationMidTextBox.TabIndex = 14
        ' 
        ' caseStudyMidLabel
        ' 
        caseStudyMidLabel.AutoSize = True
        caseStudyMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        caseStudyMidLabel.ForeColor = SystemColors.ButtonHighlight
        caseStudyMidLabel.Location = New Point(278, 24)
        caseStudyMidLabel.Name = "caseStudyMidLabel"
        caseStudyMidLabel.Size = New Size(138, 23)
        caseStudyMidLabel.TabIndex = 13
        caseStudyMidLabel.Text = "Case Study %"
        ' 
        ' caseStudyMidTextBox
        ' 
        caseStudyMidTextBox.Font = New Font("Lucida Sans", 12F)
        caseStudyMidTextBox.Location = New Point(278, 50)
        caseStudyMidTextBox.Name = "caseStudyMidTextBox"
        caseStudyMidTextBox.Size = New Size(184, 31)
        caseStudyMidTextBox.TabIndex = 12
        ' 
        ' labExerMidTextBox
        ' 
        labExerMidTextBox.Font = New Font("Lucida Sans", 12F)
        labExerMidTextBox.Location = New Point(52, 210)
        labExerMidTextBox.Name = "labExerMidTextBox"
        labExerMidTextBox.Size = New Size(184, 31)
        labExerMidTextBox.TabIndex = 11
        ' 
        ' labExerMidLabel
        ' 
        labExerMidLabel.AutoSize = True
        labExerMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labExerMidLabel.ForeColor = SystemColors.ButtonHighlight
        labExerMidLabel.Location = New Point(52, 184)
        labExerMidLabel.Name = "labExerMidLabel"
        labExerMidLabel.Size = New Size(153, 23)
        labExerMidLabel.TabIndex = 10
        labExerMidLabel.Text = "Lab Exercise %"
        ' 
        ' quizMidTextBox
        ' 
        quizMidTextBox.Font = New Font("Lucida Sans", 12F)
        quizMidTextBox.Location = New Point(52, 127)
        quizMidTextBox.Name = "quizMidTextBox"
        quizMidTextBox.Size = New Size(184, 31)
        quizMidTextBox.TabIndex = 9
        ' 
        ' clearMidtermButton
        ' 
        clearMidtermButton.Font = New Font("Lucida Sans", 12F)
        clearMidtermButton.Location = New Point(504, 127)
        clearMidtermButton.Name = "clearMidtermButton"
        clearMidtermButton.Size = New Size(169, 48)
        clearMidtermButton.TabIndex = 8
        clearMidtermButton.Text = "Clear"
        clearMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' computeMidtermButton
        ' 
        computeMidtermButton.Font = New Font("Lucida Sans", 12F)
        computeMidtermButton.Location = New Point(504, 73)
        computeMidtermButton.Name = "computeMidtermButton"
        computeMidtermButton.Size = New Size(169, 48)
        computeMidtermButton.TabIndex = 7
        computeMidtermButton.Text = "Compute"
        computeMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermGradeLabel
        ' 
        midtermGradeLabel.AutoSize = True
        midtermGradeLabel.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        midtermGradeLabel.BorderStyle = BorderStyle.Fixed3D
        midtermGradeLabel.Font = New Font("Lucida Sans", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midtermGradeLabel.ForeColor = SystemColors.ButtonHighlight
        midtermGradeLabel.Location = New Point(691, 114)
        midtermGradeLabel.Name = "midtermGradeLabel"
        midtermGradeLabel.Size = New Size(143, 93)
        midtermGradeLabel.TabIndex = 6
        midtermGradeLabel.Text = "00"
        midtermGradeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quizMidLabel
        ' 
        quizMidLabel.AutoSize = True
        quizMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quizMidLabel.ForeColor = SystemColors.ButtonHighlight
        quizMidLabel.Location = New Point(52, 101)
        quizMidLabel.Name = "quizMidLabel"
        quizMidLabel.Size = New Size(108, 23)
        quizMidLabel.TabIndex = 4
        quizMidLabel.Text = "Quizzes %"
        ' 
        ' attendanceMidLabel
        ' 
        attendanceMidLabel.AutoSize = True
        attendanceMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        attendanceMidLabel.ForeColor = SystemColors.ButtonHighlight
        attendanceMidLabel.Location = New Point(52, 24)
        attendanceMidLabel.Name = "attendanceMidLabel"
        attendanceMidLabel.Size = New Size(142, 23)
        attendanceMidLabel.TabIndex = 3
        attendanceMidLabel.Text = "Attendance %"
        ' 
        ' attMidTextBox
        ' 
        attMidTextBox.Font = New Font("Lucida Sans", 12F)
        attMidTextBox.Location = New Point(52, 50)
        attMidTextBox.Name = "attMidTextBox"
        attMidTextBox.Size = New Size(184, 31)
        attMidTextBox.TabIndex = 0
        ' 
        ' finalPanel
        ' 
        finalPanel.BackColor = Color.FromArgb(CByte(16), CByte(55), CByte(92))
        finalPanel.Controls.Add(setPercentageFinalButton)
        finalPanel.Controls.Add(saveCSFinalButton)
        finalPanel.Controls.Add(finalCSGradeLabel)
        finalPanel.Controls.Add(Label5)
        finalPanel.Controls.Add(examCSFinTextBox)
        finalPanel.Controls.Add(Label7)
        finalPanel.Controls.Add(caseStudyCSFinTextBox)
        finalPanel.Controls.Add(LabExerCSFinTextBox)
        finalPanel.Controls.Add(Label8)
        finalPanel.Controls.Add(quizCSFinTextBox)
        finalPanel.Controls.Add(clearCSFinalButton)
        finalPanel.Controls.Add(computeCSFinalButton)
        finalPanel.Controls.Add(finalCSGrade)
        finalPanel.Controls.Add(Label10)
        finalPanel.Controls.Add(Label11)
        finalPanel.Controls.Add(attCSFinTextBox)
        finalPanel.Location = New Point(36, 462)
        finalPanel.Name = "finalPanel"
        finalPanel.Size = New Size(954, 276)
        finalPanel.TabIndex = 1
        finalPanel.Visible = False
        ' 
        ' setPercentageFinalButton
        ' 
        setPercentageFinalButton.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        setPercentageFinalButton.Location = New Point(504, 214)
        setPercentageFinalButton.Name = "setPercentageFinalButton"
        setPercentageFinalButton.Size = New Size(169, 48)
        setPercentageFinalButton.TabIndex = 21
        setPercentageFinalButton.Text = "Set Percentage"
        setPercentageFinalButton.UseVisualStyleBackColor = True
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
        Label5.Size = New Size(117, 23)
        Label5.TabIndex = 32
        Label5.Text = "Final Exam"
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
        Label7.Size = New Size(188, 21)
        Label7.TabIndex = 28
        Label7.Text = "Project / Case Study"
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
        Label8.Size = New Size(134, 23)
        Label8.TabIndex = 25
        Label8.Text = "Lab Exercise"
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
        clearCSFinalButton.Location = New Point(504, 157)
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
        Label10.Size = New Size(89, 23)
        Label10.TabIndex = 20
        Label10.Text = "Quizzes"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans", 12F)
        Label11.ForeColor = SystemColors.ButtonHighlight
        Label11.Location = New Point(52, 37)
        Label11.Name = "Label11"
        Label11.Size = New Size(123, 23)
        Label11.TabIndex = 19
        Label11.Text = "Attendance"
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
        ' nullMidtermPanel
        ' 
        nullMidtermPanel.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        nullMidtermPanel.Controls.Add(nullRecordPanel1)
        nullMidtermPanel.Location = New Point(36, 180)
        nullMidtermPanel.Name = "nullMidtermPanel"
        nullMidtermPanel.Size = New Size(954, 267)
        nullMidtermPanel.TabIndex = 17
        nullMidtermPanel.Visible = False
        ' 
        ' nullRecordPanel1
        ' 
        nullRecordPanel1.BackColor = Color.Gray
        nullRecordPanel1.Controls.Add(nullRecordMidterm)
        nullRecordPanel1.Location = New Point(77, 84)
        nullRecordPanel1.Name = "nullRecordPanel1"
        nullRecordPanel1.Size = New Size(796, 107)
        nullRecordPanel1.TabIndex = 1
        ' 
        ' nullRecordMidterm
        ' 
        nullRecordMidterm.AutoSize = True
        nullRecordMidterm.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nullRecordMidterm.ForeColor = SystemColors.Control
        nullRecordMidterm.Location = New Point(16, 17)
        nullRecordMidterm.Name = "nullRecordMidterm"
        nullRecordMidterm.Size = New Size(780, 76)
        nullRecordMidterm.TabIndex = 0
        nullRecordMidterm.Text = "RECORD NOT FOUND..."
        ' 
        ' nullFinalPanel
        ' 
        nullFinalPanel.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        nullFinalPanel.Controls.Add(nullRecordPanel2)
        nullFinalPanel.Location = New Point(36, 462)
        nullFinalPanel.Name = "nullFinalPanel"
        nullFinalPanel.Size = New Size(954, 276)
        nullFinalPanel.TabIndex = 18
        nullFinalPanel.Visible = False
        ' 
        ' nullRecordPanel2
        ' 
        nullRecordPanel2.BackColor = Color.Gray
        nullRecordPanel2.Controls.Add(nullRecordFinal)
        nullRecordPanel2.Location = New Point(77, 79)
        nullRecordPanel2.Name = "nullRecordPanel2"
        nullRecordPanel2.Size = New Size(796, 107)
        nullRecordPanel2.TabIndex = 2
        ' 
        ' nullRecordFinal
        ' 
        nullRecordFinal.AutoSize = True
        nullRecordFinal.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nullRecordFinal.ForeColor = SystemColors.Control
        nullRecordFinal.Location = New Point(16, 17)
        nullRecordFinal.Name = "nullRecordFinal"
        nullRecordFinal.Size = New Size(780, 76)
        nullRecordFinal.TabIndex = 0
        nullRecordFinal.Text = "RECORD NOT FOUND..."
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
        Controls.Add(finalPanel)
        Controls.Add(midtermPanel)
        Controls.Add(nullMidtermPanel)
        Controls.Add(nullFinalPanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "GradeForm"
        Text = "Grade Form"
        midtermPanel.ResumeLayout(False)
        midtermPanel.PerformLayout()
        finalPanel.ResumeLayout(False)
        finalPanel.PerformLayout()
        nullMidtermPanel.ResumeLayout(False)
        nullRecordPanel1.ResumeLayout(False)
        nullRecordPanel1.PerformLayout()
        nullFinalPanel.ResumeLayout(False)
        nullRecordPanel2.ResumeLayout(False)
        nullRecordPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents midtermPanel As Panel
    Friend WithEvents finalPanel As Panel
    Friend WithEvents studentNameTextBox As TextBox
    Friend WithEvents studentNumberLabel As Label
    Friend WithEvents studentNameLabel As Label
    Friend WithEvents attMidTextBox As TextBox
    Friend WithEvents quizMidLabel As Label
    Friend WithEvents attendanceMidLabel As Label
    Friend WithEvents midtermGradeLabel As Label
    Friend WithEvents clearMidtermButton As Button
    Friend WithEvents computeMidtermButton As Button
    Friend WithEvents semGrade As Label
    Friend WithEvents quizMidTextBox As TextBox
    Friend WithEvents caseStudyMidLabel As Label
    Friend WithEvents caseStudyMidTextBox As TextBox
    Friend WithEvents labExerMidTextBox As TextBox
    Friend WithEvents labExerMidLabel As Label
    Friend WithEvents examMidLabel As Label
    Friend WithEvents examMidTextBox As TextBox
    Friend WithEvents recitationMidLabel As Label
    Friend WithEvents recitationMidTextBox As TextBox
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
    Friend WithEvents midtermPercLabel As Label
    Friend WithEvents finalCSGradeLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents studentNumberTextBox As MaskedTextBox
    Friend WithEvents saveMidtermButton As Button
    Friend WithEvents saveCSFinalButton As Button
    Friend WithEvents courseLabel As Label
    Friend WithEvents studentCourseTextBox As TextBox
    Friend WithEvents sectionLabel As Label
    Friend WithEvents studentSectionTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents setPercentageMidButton As Button
    Friend WithEvents setPercentageFinalButton As Button
    Friend WithEvents nullMidtermPanel As Panel
    Friend WithEvents nullFinalPanel As Panel
    Friend WithEvents nullRecordMidterm As Label
    Friend WithEvents nullRecordPanel1 As Panel
    Friend WithEvents nullRecordPanel2 As Panel
    Friend WithEvents nullRecordFinal As Label
End Class
