USE Task6DB;
ALTER TABLE [dbo].[Student]
   ADD CONSTRAINT FK_Group_Id FOREIGN KEY (GroupID)
      REFERENCES [dbo].[Group] (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE [dbo].[Examination]
   ADD CONSTRAINT FK_Group_Id FOREIGN KEY (GroupID)
      REFERENCES [dbo].[Group] (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE [dbo].[Examination]
   ADD CONSTRAINT FK_Subject_Id FOREIGN KEY (SubjectID)
      REFERENCES [dbo].[Subject] (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE [dbo].[Examination]
   ADD CONSTRAINT FK_Session_Id FOREIGN KEY (SessionID)
      REFERENCES [dbo].[Session] (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE [dbo].[StudentGrade]
   ADD CONSTRAINT FK_Examination_Id FOREIGN KEY (ExaminationID)
      REFERENCES [dbo].[Examination] (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE [dbo].[StudentGrade]
   ADD CONSTRAINT FK_Student_Id FOREIGN KEY (StudentID)
      REFERENCES [dbo].[Student] (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;