using System.ComponentModel;

namespace TestWorkflow;

partial class TestWorkflowForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnEvent = new Button();
        btnStart = new Button();
        SuspendLayout();
        // 
        // btnEvent
        // 
        btnEvent.Location = new Point(337, 199);
        btnEvent.Name = "btnEvent";
        btnEvent.Size = new Size(94, 29);
        btnEvent.TabIndex = 0;
        btnEvent.Text = "Событие";
        btnEvent.UseVisualStyleBackColor = true;
        btnEvent.Click += btnEvent_Click;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(337, 120);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(94, 29);
        btnStart.TabIndex = 0;
        btnStart.Text = "Старт";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // TestWorkflowForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnEvent);
        Controls.Add(btnStart);
        Name = "TestWorkflowForm";
        Text = "TestWorkflowForm";
        ResumeLayout(false);
    }

    #endregion

    private Button btnEvent;
    private Button btnStart;
}