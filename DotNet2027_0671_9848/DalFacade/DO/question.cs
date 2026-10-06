using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DO
{
    public record Question
    {
        public int id { get; set; }
        public SubjQuestionEnum Sub { get; set; }
        public string contentQues { get; set; } = string.Empty;
        public int correctAnsId { get; set; }

        public Question()
        {

        }
        public Question(int id, int Sub, string contentQues, int correctAnsId)
        {
            this.id = id;
            this.Sub = (SubjQuestionEnum)Sub;
            this.contentQues = contentQues;
            this.correctAnsId = correctAnsId;
        }
        public override string ToString() {
            return $"Question ID: {id}, Subject: {Sub}, Content: {contentQues}, Correct Answer ID: {correctAnsId}";
             }
        }
}

