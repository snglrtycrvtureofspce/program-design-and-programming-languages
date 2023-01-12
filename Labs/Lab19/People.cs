using System;

namespace Lab19
{
    public class People
    {
        public string surname;
        public string faculty;
        public string course;
        public string group;
        public int[] mark;
        public People(string s)
        {
            string[] text = s.Split(' ');
            this.surname = text[0];
            this.faculty = text[1];
            this.group = text[2];
            this.course = text[3];
            int[] arr = new int[5];
            arr[0] = Convert.ToInt32(text[4]);
            arr[1] = Convert.ToInt32(text[5]);
            arr[2] = Convert.ToInt32(text[6]);
            arr[3] = Convert.ToInt32(text[7]);
            arr[4] = Convert.ToInt32(text[8]);
            this.mark = arr;
        }
        public override string ToString()
        {
            return $"Surname: {this.surname}\nFaculty: {this.faculty}\nCourse: {this.course}\nGroup: {this.group}\nMark: {this.mark[0]},{this.mark[1]},{this.mark[2]},{this.mark[3]},{this.mark[4]}";
        }
        public bool Double()
        {
            for(int i = 0; i < 5;i++)
            {
                if(mark[i] == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}