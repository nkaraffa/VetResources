using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetResource.Models;

namespace VetResource.Services
{
    public class DBRepository : IVetRepository, IVso, IFeedback
    {
        private VetResContext _vetResContext;
        public DBRepository(VetResContext vetResContext)
        {
            _vetResContext = vetResContext;
        }

        // Resources Content (ResCont)
        #region ResCont
        public IEnumerable<ResCont> GetAllResources()
        {
            return _vetResContext.ResCont.ToList();
        }

        public ResCont GetResCont(int id)
        {
            return _vetResContext.ResCont.FirstOrDefault(r => r.ResourceId == id);
        }
        #endregion

        // VSO Methods
        #region VSO
        public IEnumerable<Vsocont> GetVsoconts()
        {
            return _vetResContext.Vsocont.ToList();
        }

        public Vsocont GetVsocont(int id)
        {
            return _vetResContext.Vsocont.FirstOrDefault(v => v.VsoId == id);
        }
        #endregion

        //Feedback Methods
        #region Feedback
        public IEnumerable<Feedback> GetFeedbacks()
        {
            return _vetResContext.Feedback.ToList();
        }

        public Feedback GetFeedback(int id)
        {
            return _vetResContext.Feedback.FirstOrDefault(f => f.FeedbackId == id);
        }        

        public Feedback CreateFeedBack(Feedback feedback)
        {
            feedback.FeedbackId = _vetResContext.Feedback.Max(f => f.FeedbackId) +1;
            _vetResContext.Feedback.Add(feedback);
            _vetResContext.SaveChanges();

            return feedback;
        }

        public Feedback UpdateFeedback(Feedback feedbackChange)
        {
            Feedback feedback = _vetResContext.Feedback.FirstOrDefault(f => f.FeedbackId == feedbackChange.FeedbackId);
            if (feedback != null)
            {
                feedback.Name = feedbackChange.Name;
                feedback.Email = feedbackChange.Email;
                feedback.Subject = feedbackChange.Subject;
                feedback.FeedbackText = feedbackChange.FeedbackText;
            }
            _vetResContext.SaveChanges();
            return feedback;
        }

        public Feedback DeleteFeedback(int id)
        {
            Feedback feedback = _vetResContext.Feedback.FirstOrDefault(f => f.FeedbackId == id);
            if(feedback != null)
            {
                _vetResContext.Feedback.Remove(feedback);
            }
            _vetResContext.SaveChanges();
            return feedback;
        }
        
        #endregion
    }
}
