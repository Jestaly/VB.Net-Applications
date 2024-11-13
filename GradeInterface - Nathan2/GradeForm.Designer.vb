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
        studentNameTextBox = New TextBox()
        studentNumberLabel = New Label()
        studentNameLabel = New Label()
        semGrade = New Label()
        Label12 = New Label()
        studentNumberTextBox = New MaskedTextBox()
        programLabel = New Label()
        studentProgramTextBox = New TextBox()
        sectionLabel = New Label()
        studentSectionTextBox = New TextBox()
        searchButton = New Button()
        nullMidtermPanel = New Panel()
        nullRecordPanel1 = New Panel()
        nullRecordMidterm = New Label()
        nullFinalPanel = New Panel()
        nullRecordPanel2 = New Panel()
        nullRecordFinal = New Label()
        finalPanel = New Panel()
        setPercentageFinButton = New Button()
        saveFinalButton = New Button()
        finalPercLabel = New Label()
        examFinLabel = New Label()
        examFinTextBox = New TextBox()
        caseStudyFinLabel = New Label()
        caseStudyFinTextBox = New TextBox()
        labExerFinTextBox = New TextBox()
        labExerFinLabel = New Label()
        quizFinTextBox = New TextBox()
        clearFinalButton = New Button()
        computeFinalButton = New Button()
        FinalGradeLabel = New Label()
        quizFinLabel = New Label()
        attendanceFinLabel = New Label()
        attFinTextBox = New TextBox()
        noRecordsYetPanel = New Panel()
        Panel2 = New Panel()
        noRecordsYetLabel = New Label()
        CScomboBox = New ComboBox()
        courseLabel = New Label()
        ITcomboBox = New ComboBox()
        EDUCcomboBox = New ComboBox()
        midtermPanel.SuspendLayout()
        nullMidtermPanel.SuspendLayout()
        nullRecordPanel1.SuspendLayout()
        nullFinalPanel.SuspendLayout()
        nullRecordPanel2.SuspendLayout()
        finalPanel.SuspendLayout()
        noRecordsYetPanel.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' midtermPanel
        ' 
        midtermPanel.BackColor = Color.Gray
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
        midtermPanel.Location = New Point(372, 39)
        midtermPanel.Name = "midtermPanel"
        midtermPanel.Size = New Size(291, 700)
        midtermPanel.TabIndex = 0
        midtermPanel.Visible = False
        ' 
        ' setPercentageMidButton
        ' 
        setPercentageMidButton.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        setPercentageMidButton.Location = New Point(52, 511)
        setPercentageMidButton.Name = "setPercentageMidButton"
        setPercentageMidButton.Size = New Size(186, 41)
        setPercentageMidButton.TabIndex = 20
        setPercentageMidButton.Text = "Set Percentage"
        setPercentageMidButton.UseVisualStyleBackColor = True
        ' 
        ' saveMidtermButton
        ' 
        saveMidtermButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveMidtermButton.Location = New Point(36, 616)
        saveMidtermButton.Name = "saveMidtermButton"
        saveMidtermButton.Size = New Size(79, 36)
        saveMidtermButton.TabIndex = 19
        saveMidtermButton.Text = "Save"
        saveMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermPercLabel
        ' 
        midtermPercLabel.AutoSize = True
        midtermPercLabel.Font = New Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midtermPercLabel.ForeColor = SystemColors.ButtonHighlight
        midtermPercLabel.Location = New Point(39, 563)
        midtermPercLabel.Name = "midtermPercLabel"
        midtermPercLabel.Size = New Size(199, 21)
        midtermPercLabel.TabIndex = 18
        midtermPercLabel.Text = "MIDTERM GRADE: 0%"
        ' 
        ' examMidLabel
        ' 
        examMidLabel.AutoSize = True
        examMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        examMidLabel.ForeColor = SystemColors.ButtonHighlight
        examMidLabel.Location = New Point(50, 342)
        examMidLabel.Name = "examMidLabel"
        examMidLabel.Size = New Size(171, 23)
        examMidLabel.TabIndex = 17
        examMidLabel.Text = "Midterm Exam %"
        ' 
        ' examMidTextBox
        ' 
        examMidTextBox.Enabled = False
        examMidTextBox.Font = New Font("Lucida Sans", 12F)
        examMidTextBox.Location = New Point(52, 368)
        examMidTextBox.Name = "examMidTextBox"
        examMidTextBox.Size = New Size(184, 31)
        examMidTextBox.TabIndex = 16
        ' 
        ' recitationMidLabel
        ' 
        recitationMidLabel.AutoSize = True
        recitationMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        recitationMidLabel.ForeColor = SystemColors.ButtonHighlight
        recitationMidLabel.Location = New Point(54, 276)
        recitationMidLabel.Name = "recitationMidLabel"
        recitationMidLabel.Size = New Size(128, 23)
        recitationMidLabel.TabIndex = 15
        recitationMidLabel.Text = "Recitation %"
        ' 
        ' recitationMidTextBox
        ' 
        recitationMidTextBox.Enabled = False
        recitationMidTextBox.Font = New Font("Lucida Sans", 12F)
        recitationMidTextBox.Location = New Point(54, 302)
        recitationMidTextBox.Name = "recitationMidTextBox"
        recitationMidTextBox.Size = New Size(182, 31)
        recitationMidTextBox.TabIndex = 14
        ' 
        ' caseStudyMidLabel
        ' 
        caseStudyMidLabel.AutoSize = True
        caseStudyMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        caseStudyMidLabel.ForeColor = SystemColors.ButtonHighlight
        caseStudyMidLabel.Location = New Point(54, 213)
        caseStudyMidLabel.Name = "caseStudyMidLabel"
        caseStudyMidLabel.Size = New Size(138, 23)
        caseStudyMidLabel.TabIndex = 13
        caseStudyMidLabel.Text = "Case Study %"
        ' 
        ' caseStudyMidTextBox
        ' 
        caseStudyMidTextBox.Enabled = False
        caseStudyMidTextBox.Font = New Font("Lucida Sans", 12F)
        caseStudyMidTextBox.Location = New Point(54, 239)
        caseStudyMidTextBox.Name = "caseStudyMidTextBox"
        caseStudyMidTextBox.Size = New Size(184, 31)
        caseStudyMidTextBox.TabIndex = 12
        ' 
        ' labExerMidTextBox
        ' 
        labExerMidTextBox.Enabled = False
        labExerMidTextBox.Font = New Font("Lucida Sans", 12F)
        labExerMidTextBox.Location = New Point(54, 174)
        labExerMidTextBox.Name = "labExerMidTextBox"
        labExerMidTextBox.Size = New Size(184, 31)
        labExerMidTextBox.TabIndex = 11
        ' 
        ' labExerMidLabel
        ' 
        labExerMidLabel.AutoSize = True
        labExerMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labExerMidLabel.ForeColor = SystemColors.ButtonHighlight
        labExerMidLabel.Location = New Point(54, 148)
        labExerMidLabel.Name = "labExerMidLabel"
        labExerMidLabel.Size = New Size(153, 23)
        labExerMidLabel.TabIndex = 10
        labExerMidLabel.Text = "Lab Exercise %"
        ' 
        ' quizMidTextBox
        ' 
        quizMidTextBox.Enabled = False
        quizMidTextBox.Font = New Font("Lucida Sans", 12F)
        quizMidTextBox.Location = New Point(54, 114)
        quizMidTextBox.Name = "quizMidTextBox"
        quizMidTextBox.Size = New Size(184, 31)
        quizMidTextBox.TabIndex = 9
        ' 
        ' clearMidtermButton
        ' 
        clearMidtermButton.Font = New Font("Lucida Sans", 12F)
        clearMidtermButton.Location = New Point(52, 464)
        clearMidtermButton.Name = "clearMidtermButton"
        clearMidtermButton.Size = New Size(186, 41)
        clearMidtermButton.TabIndex = 8
        clearMidtermButton.Text = "Clear"
        clearMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' computeMidtermButton
        ' 
        computeMidtermButton.Font = New Font("Lucida Sans", 12F)
        computeMidtermButton.Location = New Point(52, 417)
        computeMidtermButton.Name = "computeMidtermButton"
        computeMidtermButton.Size = New Size(186, 41)
        computeMidtermButton.TabIndex = 7
        computeMidtermButton.Text = "Compute"
        computeMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermGradeLabel
        ' 
        midtermGradeLabel.AutoSize = True
        midtermGradeLabel.BackColor = Color.Black
        midtermGradeLabel.BorderStyle = BorderStyle.Fixed3D
        midtermGradeLabel.Font = New Font("Lucida Sans", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midtermGradeLabel.ForeColor = SystemColors.ButtonHighlight
        midtermGradeLabel.Location = New Point(132, 605)
        midtermGradeLabel.Name = "midtermGradeLabel"
        midtermGradeLabel.Size = New Size(85, 56)
        midtermGradeLabel.TabIndex = 6
        midtermGradeLabel.Text = "00"
        midtermGradeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quizMidLabel
        ' 
        quizMidLabel.AutoSize = True
        quizMidLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quizMidLabel.ForeColor = SystemColors.ButtonHighlight
        quizMidLabel.Location = New Point(52, 88)
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
        attendanceMidLabel.Location = New Point(54, 24)
        attendanceMidLabel.Name = "attendanceMidLabel"
        attendanceMidLabel.Size = New Size(142, 23)
        attendanceMidLabel.TabIndex = 3
        attendanceMidLabel.Text = "Attendance %"
        ' 
        ' attMidTextBox
        ' 
        attMidTextBox.Enabled = False
        attMidTextBox.Font = New Font("Lucida Sans", 12F)
        attMidTextBox.Location = New Point(54, 50)
        attMidTextBox.Name = "attMidTextBox"
        attMidTextBox.Size = New Size(182, 31)
        attMidTextBox.TabIndex = 0
        ' 
        ' studentNameTextBox
        ' 
        studentNameTextBox.Enabled = False
        studentNameTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNameTextBox.Location = New Point(76, 383)
        studentNameTextBox.Name = "studentNameTextBox"
        studentNameTextBox.Size = New Size(269, 31)
        studentNameTextBox.TabIndex = 2
        ' 
        ' studentNumberLabel
        ' 
        studentNumberLabel.AutoSize = True
        studentNumberLabel.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNumberLabel.ForeColor = SystemColors.ButtonHighlight
        studentNumberLabel.Location = New Point(76, 294)
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
        studentNameLabel.Location = New Point(76, 359)
        studentNameLabel.Name = "studentNameLabel"
        studentNameLabel.Size = New Size(136, 21)
        studentNameLabel.TabIndex = 4
        studentNameLabel.Text = "Student Name"
        ' 
        ' semGrade
        ' 
        semGrade.AutoSize = True
        semGrade.BackColor = Color.Black
        semGrade.BorderStyle = BorderStyle.Fixed3D
        semGrade.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        semGrade.ForeColor = SystemColors.ButtonHighlight
        semGrade.Location = New Point(76, 197)
        semGrade.Name = "semGrade"
        semGrade.Size = New Size(174, 78)
        semGrade.TabIndex = 9
        semGrade.Text = "X.XX"
        semGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(76, 173)
        Label12.Name = "Label12"
        Label12.Size = New Size(142, 19)
        Label12.TabIndex = 10
        Label12.Text = "Semestral Grade"
        ' 
        ' studentNumberTextBox
        ' 
        studentNumberTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNumberTextBox.Location = New Point(76, 318)
        studentNumberTextBox.Mask = "00-00000"
        studentNumberTextBox.Name = "studentNumberTextBox"
        studentNumberTextBox.PromptChar = "X"c
        studentNumberTextBox.Size = New Size(144, 31)
        studentNumberTextBox.TabIndex = 11
        studentNumberTextBox.ValidatingType = GetType(Date)
        ' 
        ' programLabel
        ' 
        programLabel.AutoSize = True
        programLabel.Font = New Font("Lucida Sans", 10.8F)
        programLabel.ForeColor = SystemColors.ButtonHighlight
        programLabel.Location = New Point(76, 417)
        programLabel.Name = "programLabel"
        programLabel.Size = New Size(87, 21)
        programLabel.TabIndex = 13
        programLabel.Text = "Program"
        ' 
        ' studentProgramTextBox
        ' 
        studentProgramTextBox.Enabled = False
        studentProgramTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentProgramTextBox.Location = New Point(76, 441)
        studentProgramTextBox.Name = "studentProgramTextBox"
        studentProgramTextBox.Size = New Size(136, 31)
        studentProgramTextBox.TabIndex = 12
        ' 
        ' sectionLabel
        ' 
        sectionLabel.AutoSize = True
        sectionLabel.Font = New Font("Lucida Sans", 10.8F)
        sectionLabel.ForeColor = SystemColors.ButtonHighlight
        sectionLabel.Location = New Point(77, 478)
        sectionLabel.Name = "sectionLabel"
        sectionLabel.Size = New Size(135, 21)
        sectionLabel.TabIndex = 15
        sectionLabel.Text = "Year / Section"
        ' 
        ' studentSectionTextBox
        ' 
        studentSectionTextBox.Enabled = False
        studentSectionTextBox.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentSectionTextBox.Location = New Point(77, 503)
        studentSectionTextBox.Name = "studentSectionTextBox"
        studentSectionTextBox.Size = New Size(135, 31)
        studentSectionTextBox.TabIndex = 14
        ' 
        ' searchButton
        ' 
        searchButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.Location = New Point(226, 320)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(82, 29)
        searchButton.TabIndex = 16
        searchButton.Text = "Enter"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' nullMidtermPanel
        ' 
        nullMidtermPanel.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        nullMidtermPanel.Controls.Add(nullRecordPanel1)
        nullMidtermPanel.Location = New Point(369, 39)
        nullMidtermPanel.Name = "nullMidtermPanel"
        nullMidtermPanel.Size = New Size(294, 700)
        nullMidtermPanel.TabIndex = 17
        nullMidtermPanel.Visible = False
        ' 
        ' nullRecordPanel1
        ' 
        nullRecordPanel1.BackColor = Color.Gray
        nullRecordPanel1.Controls.Add(nullRecordMidterm)
        nullRecordPanel1.Location = New Point(78, 87)
        nullRecordPanel1.Name = "nullRecordPanel1"
        nullRecordPanel1.Size = New Size(112, 549)
        nullRecordPanel1.TabIndex = 1
        ' 
        ' nullRecordMidterm
        ' 
        nullRecordMidterm.AutoSize = True
        nullRecordMidterm.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nullRecordMidterm.ForeColor = SystemColors.Control
        nullRecordMidterm.Location = New Point(16, 17)
        nullRecordMidterm.Name = "nullRecordMidterm"
        nullRecordMidterm.Size = New Size(0, 76)
        nullRecordMidterm.TabIndex = 0
        ' 
        ' nullFinalPanel
        ' 
        nullFinalPanel.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        nullFinalPanel.Controls.Add(nullRecordPanel2)
        nullFinalPanel.Location = New Point(678, 42)
        nullFinalPanel.Name = "nullFinalPanel"
        nullFinalPanel.Size = New Size(291, 700)
        nullFinalPanel.TabIndex = 18
        nullFinalPanel.Visible = False
        ' 
        ' nullRecordPanel2
        ' 
        nullRecordPanel2.BackColor = Color.Gray
        nullRecordPanel2.Controls.Add(nullRecordFinal)
        nullRecordPanel2.Location = New Point(81, 87)
        nullRecordPanel2.Name = "nullRecordPanel2"
        nullRecordPanel2.Size = New Size(117, 549)
        nullRecordPanel2.TabIndex = 2
        ' 
        ' nullRecordFinal
        ' 
        nullRecordFinal.AutoSize = True
        nullRecordFinal.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nullRecordFinal.ForeColor = SystemColors.Control
        nullRecordFinal.Location = New Point(16, 17)
        nullRecordFinal.Name = "nullRecordFinal"
        nullRecordFinal.Size = New Size(0, 76)
        nullRecordFinal.TabIndex = 0
        ' 
        ' finalPanel
        ' 
        finalPanel.BackColor = Color.Gray
        finalPanel.Controls.Add(setPercentageFinButton)
        finalPanel.Controls.Add(saveFinalButton)
        finalPanel.Controls.Add(finalPercLabel)
        finalPanel.Controls.Add(examFinLabel)
        finalPanel.Controls.Add(examFinTextBox)
        finalPanel.Controls.Add(caseStudyFinLabel)
        finalPanel.Controls.Add(caseStudyFinTextBox)
        finalPanel.Controls.Add(labExerFinTextBox)
        finalPanel.Controls.Add(labExerFinLabel)
        finalPanel.Controls.Add(quizFinTextBox)
        finalPanel.Controls.Add(clearFinalButton)
        finalPanel.Controls.Add(computeFinalButton)
        finalPanel.Controls.Add(FinalGradeLabel)
        finalPanel.Controls.Add(quizFinLabel)
        finalPanel.Controls.Add(attendanceFinLabel)
        finalPanel.Controls.Add(attFinTextBox)
        finalPanel.Location = New Point(681, 39)
        finalPanel.Name = "finalPanel"
        finalPanel.Size = New Size(288, 700)
        finalPanel.TabIndex = 19
        finalPanel.Visible = False
        ' 
        ' setPercentageFinButton
        ' 
        setPercentageFinButton.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        setPercentageFinButton.Location = New Point(52, 509)
        setPercentageFinButton.Name = "setPercentageFinButton"
        setPercentageFinButton.Size = New Size(184, 42)
        setPercentageFinButton.TabIndex = 20
        setPercentageFinButton.Text = "Set Percentage"
        setPercentageFinButton.UseVisualStyleBackColor = True
        ' 
        ' saveFinalButton
        ' 
        saveFinalButton.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveFinalButton.Location = New Point(42, 616)
        saveFinalButton.Name = "saveFinalButton"
        saveFinalButton.Size = New Size(79, 36)
        saveFinalButton.TabIndex = 19
        saveFinalButton.Text = "Save"
        saveFinalButton.UseVisualStyleBackColor = True
        ' 
        ' finalPercLabel
        ' 
        finalPercLabel.AutoSize = True
        finalPercLabel.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        finalPercLabel.ForeColor = SystemColors.ButtonHighlight
        finalPercLabel.Location = New Point(53, 563)
        finalPercLabel.Name = "finalPercLabel"
        finalPercLabel.Size = New Size(152, 19)
        finalPercLabel.TabIndex = 18
        finalPercLabel.Text = "FINAL GRADE: 0%"
        ' 
        ' examFinLabel
        ' 
        examFinLabel.AutoSize = True
        examFinLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        examFinLabel.ForeColor = SystemColors.ButtonHighlight
        examFinLabel.Location = New Point(52, 276)
        examFinLabel.Name = "examFinLabel"
        examFinLabel.Size = New Size(136, 23)
        examFinLabel.TabIndex = 17
        examFinLabel.Text = "Final Exam %"
        ' 
        ' examFinTextBox
        ' 
        examFinTextBox.Enabled = False
        examFinTextBox.Font = New Font("Lucida Sans", 12F)
        examFinTextBox.Location = New Point(52, 302)
        examFinTextBox.Name = "examFinTextBox"
        examFinTextBox.Size = New Size(184, 31)
        examFinTextBox.TabIndex = 16
        ' 
        ' caseStudyFinLabel
        ' 
        caseStudyFinLabel.AutoSize = True
        caseStudyFinLabel.Font = New Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        caseStudyFinLabel.ForeColor = SystemColors.ButtonHighlight
        caseStudyFinLabel.Location = New Point(52, 208)
        caseStudyFinLabel.Name = "caseStudyFinLabel"
        caseStudyFinLabel.Size = New Size(206, 21)
        caseStudyFinLabel.TabIndex = 13
        caseStudyFinLabel.Text = "Case Study / Project %"
        ' 
        ' caseStudyFinTextBox
        ' 
        caseStudyFinTextBox.Enabled = False
        caseStudyFinTextBox.Font = New Font("Lucida Sans", 12F)
        caseStudyFinTextBox.Location = New Point(52, 236)
        caseStudyFinTextBox.Name = "caseStudyFinTextBox"
        caseStudyFinTextBox.Size = New Size(184, 31)
        caseStudyFinTextBox.TabIndex = 12
        ' 
        ' labExerFinTextBox
        ' 
        labExerFinTextBox.Enabled = False
        labExerFinTextBox.Font = New Font("Lucida Sans", 12F)
        labExerFinTextBox.Location = New Point(52, 171)
        labExerFinTextBox.Name = "labExerFinTextBox"
        labExerFinTextBox.Size = New Size(184, 31)
        labExerFinTextBox.TabIndex = 11
        ' 
        ' labExerFinLabel
        ' 
        labExerFinLabel.AutoSize = True
        labExerFinLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labExerFinLabel.ForeColor = SystemColors.ButtonHighlight
        labExerFinLabel.Location = New Point(52, 145)
        labExerFinLabel.Name = "labExerFinLabel"
        labExerFinLabel.Size = New Size(153, 23)
        labExerFinLabel.TabIndex = 10
        labExerFinLabel.Text = "Lab Exercise %"
        ' 
        ' quizFinTextBox
        ' 
        quizFinTextBox.Enabled = False
        quizFinTextBox.Font = New Font("Lucida Sans", 12F)
        quizFinTextBox.Location = New Point(52, 111)
        quizFinTextBox.Name = "quizFinTextBox"
        quizFinTextBox.Size = New Size(184, 31)
        quizFinTextBox.TabIndex = 9
        ' 
        ' clearFinalButton
        ' 
        clearFinalButton.Font = New Font("Lucida Sans", 12F)
        clearFinalButton.Location = New Point(52, 461)
        clearFinalButton.Name = "clearFinalButton"
        clearFinalButton.Size = New Size(184, 42)
        clearFinalButton.TabIndex = 8
        clearFinalButton.Text = "Clear"
        clearFinalButton.UseVisualStyleBackColor = True
        ' 
        ' computeFinalButton
        ' 
        computeFinalButton.Font = New Font("Lucida Sans", 12F)
        computeFinalButton.Location = New Point(52, 413)
        computeFinalButton.Name = "computeFinalButton"
        computeFinalButton.Size = New Size(184, 42)
        computeFinalButton.TabIndex = 7
        computeFinalButton.Text = "Compute"
        computeFinalButton.UseVisualStyleBackColor = True
        ' 
        ' FinalGradeLabel
        ' 
        FinalGradeLabel.AutoSize = True
        FinalGradeLabel.BackColor = Color.Black
        FinalGradeLabel.BorderStyle = BorderStyle.Fixed3D
        FinalGradeLabel.Font = New Font("Lucida Sans", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FinalGradeLabel.ForeColor = SystemColors.ButtonHighlight
        FinalGradeLabel.Location = New Point(138, 605)
        FinalGradeLabel.Name = "FinalGradeLabel"
        FinalGradeLabel.Size = New Size(85, 56)
        FinalGradeLabel.TabIndex = 6
        FinalGradeLabel.Text = "00"
        FinalGradeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quizFinLabel
        ' 
        quizFinLabel.AutoSize = True
        quizFinLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quizFinLabel.ForeColor = SystemColors.ButtonHighlight
        quizFinLabel.Location = New Point(52, 85)
        quizFinLabel.Name = "quizFinLabel"
        quizFinLabel.Size = New Size(108, 23)
        quizFinLabel.TabIndex = 4
        quizFinLabel.Text = "Quizzes %"
        ' 
        ' attendanceFinLabel
        ' 
        attendanceFinLabel.AutoSize = True
        attendanceFinLabel.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        attendanceFinLabel.ForeColor = SystemColors.ButtonHighlight
        attendanceFinLabel.Location = New Point(52, 24)
        attendanceFinLabel.Name = "attendanceFinLabel"
        attendanceFinLabel.Size = New Size(142, 23)
        attendanceFinLabel.TabIndex = 3
        attendanceFinLabel.Text = "Attendance %"
        ' 
        ' attFinTextBox
        ' 
        attFinTextBox.Enabled = False
        attFinTextBox.Font = New Font("Lucida Sans", 12F)
        attFinTextBox.Location = New Point(52, 50)
        attFinTextBox.Name = "attFinTextBox"
        attFinTextBox.Size = New Size(184, 31)
        attFinTextBox.TabIndex = 0
        ' 
        ' noRecordsYetPanel
        ' 
        noRecordsYetPanel.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        noRecordsYetPanel.Controls.Add(Panel2)
        noRecordsYetPanel.Location = New Point(678, 42)
        noRecordsYetPanel.Name = "noRecordsYetPanel"
        noRecordsYetPanel.Size = New Size(294, 697)
        noRecordsYetPanel.TabIndex = 19
        noRecordsYetPanel.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gray
        Panel2.Controls.Add(noRecordsYetLabel)
        Panel2.Location = New Point(78, 84)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(119, 549)
        Panel2.TabIndex = 2
        ' 
        ' noRecordsYetLabel
        ' 
        noRecordsYetLabel.AutoSize = True
        noRecordsYetLabel.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        noRecordsYetLabel.ForeColor = SystemColors.Control
        noRecordsYetLabel.Location = New Point(104, 15)
        noRecordsYetLabel.Name = "noRecordsYetLabel"
        noRecordsYetLabel.Size = New Size(0, 76)
        noRecordsYetLabel.TabIndex = 0
        ' 
        ' CScomboBox
        ' 
        CScomboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CScomboBox.FormattingEnabled = True
        CScomboBox.Items.AddRange(New Object() {"DSA", "DSII", "COMP 104", "COMP 102"})
        CScomboBox.Location = New Point(76, 578)
        CScomboBox.Name = "CScomboBox"
        CScomboBox.Size = New Size(136, 28)
        CScomboBox.TabIndex = 20
        CScomboBox.Visible = False
        ' 
        ' courseLabel
        ' 
        courseLabel.AutoSize = True
        courseLabel.Font = New Font("Lucida Sans", 10.8F)
        courseLabel.ForeColor = SystemColors.ButtonHighlight
        courseLabel.Location = New Point(77, 554)
        courseLabel.Name = "courseLabel"
        courseLabel.Size = New Size(71, 21)
        courseLabel.TabIndex = 21
        courseLabel.Text = "Course"
        courseLabel.Visible = False
        ' 
        ' ITcomboBox
        ' 
        ITcomboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ITcomboBox.FormattingEnabled = True
        ITcomboBox.Items.AddRange(New Object() {"GE01", "PE", "N01"})
        ITcomboBox.Location = New Point(76, 578)
        ITcomboBox.Name = "ITcomboBox"
        ITcomboBox.Size = New Size(136, 28)
        ITcomboBox.TabIndex = 22
        ITcomboBox.Visible = False
        ' 
        ' EDUCcomboBox
        ' 
        EDUCcomboBox.DropDownStyle = ComboBoxStyle.DropDownList
        EDUCcomboBox.FormattingEnabled = True
        EDUCcomboBox.Items.AddRange(New Object() {"ENG1", "PE2", "GE03"})
        EDUCcomboBox.Location = New Point(76, 578)
        EDUCcomboBox.Name = "EDUCcomboBox"
        EDUCcomboBox.Size = New Size(136, 28)
        EDUCcomboBox.TabIndex = 23
        EDUCcomboBox.Visible = False
        ' 
        ' GradeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(7), CByte(63))
        ClientSize = New Size(990, 772)
        Controls.Add(courseLabel)
        Controls.Add(CScomboBox)
        Controls.Add(finalPanel)
        Controls.Add(midtermPanel)
        Controls.Add(searchButton)
        Controls.Add(sectionLabel)
        Controls.Add(studentSectionTextBox)
        Controls.Add(programLabel)
        Controls.Add(studentProgramTextBox)
        Controls.Add(studentNumberTextBox)
        Controls.Add(Label12)
        Controls.Add(semGrade)
        Controls.Add(studentNameLabel)
        Controls.Add(studentNumberLabel)
        Controls.Add(studentNameTextBox)
        Controls.Add(nullMidtermPanel)
        Controls.Add(nullFinalPanel)
        Controls.Add(noRecordsYetPanel)
        Controls.Add(ITcomboBox)
        Controls.Add(EDUCcomboBox)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "GradeForm"
        Text = "Grade Form"
        midtermPanel.ResumeLayout(False)
        midtermPanel.PerformLayout()
        nullMidtermPanel.ResumeLayout(False)
        nullRecordPanel1.ResumeLayout(False)
        nullRecordPanel1.PerformLayout()
        nullFinalPanel.ResumeLayout(False)
        nullRecordPanel2.ResumeLayout(False)
        nullRecordPanel2.PerformLayout()
        finalPanel.ResumeLayout(False)
        finalPanel.PerformLayout()
        noRecordsYetPanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents midtermPanel As Panel
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
    Friend WithEvents midtermPercLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents studentNumberTextBox As MaskedTextBox
    Friend WithEvents saveMidtermButton As Button
    Friend WithEvents programLabel As Label
    Friend WithEvents studentProgramTextBox As TextBox
    Friend WithEvents sectionLabel As Label
    Friend WithEvents studentSectionTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents setPercentageMidButton As Button
    Friend WithEvents nullMidtermPanel As Panel
    Friend WithEvents nullFinalPanel As Panel
    Friend WithEvents nullRecordMidterm As Label
    Friend WithEvents nullRecordPanel1 As Panel
    Friend WithEvents nullRecordPanel2 As Panel
    Friend WithEvents nullRecordFinal As Label
    Friend WithEvents finalPanel As Panel
    Friend WithEvents setPercentageFinButton As Button
    Friend WithEvents saveFinalButton As Button
    Friend WithEvents finalPercLabel As Label
    Friend WithEvents examFinLabel As Label
    Friend WithEvents examFinTextBox As TextBox
    Friend WithEvents caseStudyFinLabel As Label
    Friend WithEvents caseStudyFinTextBox As TextBox
    Friend WithEvents labExerFinTextBox As TextBox
    Friend WithEvents labExerFinLabel As Label
    Friend WithEvents quizFinTextBox As TextBox
    Friend WithEvents clearFinalButton As Button
    Friend WithEvents computeFinalButton As Button
    Friend WithEvents FinalGradeLabel As Label
    Friend WithEvents quizFinLabel As Label
    Friend WithEvents attendanceFinLabel As Label
    Friend WithEvents attFinTextBox As TextBox
    Friend WithEvents noRecordsYetPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents noRecordsYetLabel As Label
    Friend WithEvents CScomboBox As ComboBox
    Friend WithEvents courseLabel As Label
    Friend WithEvents ITcomboBox As ComboBox
    Friend WithEvents EDUCcomboBox As ComboBox
End Class
