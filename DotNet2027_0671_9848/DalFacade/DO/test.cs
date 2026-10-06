using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record test
    {
        public int id { get; set; }
        public  SubjTestEnum subj { get; set; }
        public DateTime date { get; set; }
        public int sumQuestions { get; set; }

        public test()
        {

        }
        public test(int id, int subj, DateTime date, int sumQuestions)
        {
            this.id = id;
            this.subj = (SubjTestEnum)subj;
            this.date = date;
            this.sumQuestions = sumQuestions;
        }
        public override string ToString()
        {
            return $"Test ID: {id}, Subject: {subj}, Date: {date}, Total Questions: {sumQuestions}";
        }
    }
}
