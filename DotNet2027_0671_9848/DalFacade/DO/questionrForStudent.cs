using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record questionrForStudent
    {
       public int studentId { get; set; }
        public int testID { get; set; }
        public int answerId { get; set; }
        public int questionSelectedID { get; set; }
        public questionrForStudent() { }
        public questionrForStudent(int studentId, int testID, int answerId, int questionSelectedID)
        {
            this.studentId = studentId;
            this.testID = testID;
            this.answerId = answerId;
            this.questionSelectedID = questionSelectedID;
        }
        public override string ToString() {
            return $"Student ID: {studentId}, Test ID: {testID}, Answer ID: {answerId}, Question Selected ID: {questionSelectedID}";
             }
        }
}
