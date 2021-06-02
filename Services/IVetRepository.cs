using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetResource.Models;

namespace VetResource.Services
{
    public interface IVetRepository
    {
        IEnumerable<ResCont> GetAllResources();
        ResCont GetResCont(int id);
    }

    public interface IVso
    {
        IEnumerable<Vsocont> GetVsoconts();
        Vsocont GetVsocont(int id);
    }

    public interface IFeedback
    {
        IEnumerable<Feedback> GetFeedbacks();
        Feedback GetFeedback(int id);
        Feedback CreateFeedBack(Feedback feedback);
        Feedback UpdateFeedback(Feedback feedbackChange);
        Feedback DeleteFeedback(int id);
    }
}
