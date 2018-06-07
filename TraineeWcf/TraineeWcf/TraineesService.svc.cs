using System;
using System.Collections.Generic;
namespace TraineeWcf
{
    public class TraineesService : ITraineesService
    {
       public List<Trainees> trainees = new List<Trainees>()
        {
            new Trainees {TraineeId=1,Name="renu",Age=20,DOB=new DateTime(1997,4,5) },
            new Trainees {TraineeId=2,Name="shi",Age=20,DOB=new DateTime(1997,6,30) }
        };
        public List<Trainees> AddTraniee(Trainees addNewTrainee)
        {
            trainees.Add(addNewTrainee);    
            return trainees;
        }
        public List<Trainees> DeleteTrainee(int deletedTraineeId)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == deletedTraineeId);
            trainees.Remove(deletingTrainee);
            return trainees;
        }
        public List<Trainees> GetTrainee()
        {
            return trainees;
        }
        public List<Trainees> UpdateTrainee(Trainees updatedTrainee)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == updatedTrainee.TraineeId);
            if (deletingTrainee == null)
                trainees.Add(updatedTrainee);        
            else
            {
                trainees.Remove(deletingTrainee);
                trainees.Add(updatedTrainee);
            }
            return trainees;
            //throw new NotImplementedException();
        }
    }
}
