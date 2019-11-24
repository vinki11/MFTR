using System.Collections.Generic;

namespace ProjetMFTR.Entities.Helper
{
	class InterlocutorServices
	{
		public InterlocutorServices()
		{

		}

		public List<Interlocutor> BuildInterlocutors(List<Adultes> adults)
		{
			List<Interlocutor> interlocutors = new List<Interlocutor>();

			foreach (var adult in adults)
			{
				Interlocutor interlocutor = new Interlocutor();
				interlocutor.FirstName = adult.Prenom;
				interlocutor.Name = adult.Nom;
				interlocutor.FullName = AdultWrapper.GetFullName(adult);
				interlocutor.Adulte_ID = adult.Adulte_ID;

				interlocutors.Add(interlocutor);
			}

			return interlocutors;
		}
	}
}
