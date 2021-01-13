// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Data_Access_Layer;
using Assignment.Domain_Layer;
using Assignment.Domain_Layer.Builders;
using Assignment.Forms.Patients;
using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Views.New_Members;
using Data_Access_Layer;
using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Domain_Layer.Person;

namespace Assignment.Presentation_Layer.Presenters.New_Members
{
    public class GPInformationPresenter
    {
        private IGPInformation view;
        private Person gp;
        private PersonAddress address;
        private PersonBuilder personBuilder;
        private AddressBuilder addressBuilder;
        // Implement Patient based on type chosen.

        public GPInformationPresenter(IGPInformation view)
        {
            this.view = view;
            personBuilder = new PersonBuilder();
            addressBuilder = new AddressBuilder();
            view.register(this);
        }

        public void btn_home_Clicked()
        {
            HomeForm hForm = new HomeForm();
            HomePresenter hp = new HomePresenter(hForm);
            hForm.Show();
        }

        public void btn_submit_Clicked()
        {
            // NEED TO DO VERIFICATION ON FORM. TRY CATCH ON REQUIRED EMPTY VARIABLES?

            if (string.IsNullOrEmpty(view.getMiddleName()))
            {
                personBuilder
                    .WithNoMiddleName((Prefix)Enum.Parse(typeof(Prefix), view.getTitle()), view.getFirstName(), view.getLastName());

                if (string.IsNullOrEmpty(view.getEmergency()))
                {
                    personBuilder
                    .WithPrimaryContactOnly(view.getPhone());

                    if (string.IsNullOrEmpty(view.getSecondLine()) && string.IsNullOrEmpty(view.getThirdLine()))
                    {
                        addressBuilder
                            .OneLineAddress(view.getFirstLine(), view.getCity(), view.getCounty(), view.getPostcode());

                    }
                    else if (string.IsNullOrEmpty(view.getThirdLine()))
                    {
                        addressBuilder
                            .TwoLineAddress(view.getFirstLine(), view.getSecondLine(), view.getCity(), view.getCounty(), view.getPostcode());
                    }
                    else
                    {
                        addressBuilder
                            .ThreeLineAddress(view.getFirstLine(), view.getSecondLine(), view.getThirdLine(), view.getCity(), view.getCounty(), view.getPostcode());
                    }
                }
                else
                {
                    personBuilder
                    .WithAllContacts(view.getPhone(), view.getEmergency());
                }

            }
            else
            {
                personBuilder
                    .WithMiddleName((Prefix)Enum.Parse(typeof(Prefix), view.getTitle()), view.getFirstName(), view.getMiddleName(), view.getLastName());
            }

            gp = personBuilder.Build();
            address = addressBuilder.Build();
            GP practice = new GP();
            practice.GPPractice = view.getPracticeName();
            MemberDB.InsertGP(gp);
            AddressDB.InsertAddress(address);
            GPDB.InsertGP(practice);

            ConfirmationForm cForm = new ConfirmationForm();
            ConfirmationPresenter cPresenter = new ConfirmationPresenter(cForm);
            cForm.Show();
        }
    }
}
