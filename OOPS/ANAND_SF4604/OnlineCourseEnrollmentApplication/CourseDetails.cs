using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseEnrollmentApplication
{
    public class CourseDetails
    {
        private static int s_courseID = 2000;
        public string CourseID { get;}
        public string CourseName { get;}
        public string TrainerName { get; set; }
        public int CourseDuration { get; set; }
        public int SeatsAvailable{ get; set; }

        public CourseDetails(string courseName,string trainerName,int courseDuration,int seatsAvailable)
        {
            s_courseID++;
            CourseID = "CS" + s_courseID;
            CourseName = courseName;
            TrainerName = trainerName;
            CourseDuration = courseDuration;
            SeatsAvailable = seatsAvailable;


        }
    }
}