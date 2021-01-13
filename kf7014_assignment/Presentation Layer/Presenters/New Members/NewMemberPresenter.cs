// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Data_Access_Layer;
using Assignment.Domain_Layer;
using Assignment.Domain_Layer.Builders;
using Assignment.Presentation_Layer.Forms;
using Assignment.Presentation_Layer.Presenters;
using Assignment.Presentation_Layer.Presenters.New_Members;
using Assignment.Views;
using Presentation_Layer.Forms.New_Members;
using static Assignment.Domain_Layer.Person;

namespace Assignment.Presenters
{
    public class NewMemberPresenter
    {
        private INewMember view;
        private Person member;
        private PersonAddress address;
        private PersonBuilder personBuilder;
        private AddressBuilder addressBuilder;
        // Implement Patient based on type chosen.

        public NewMemberPresenter(INewMember view)
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

            personBuilder
                .setMember((Member)Enum.Parse(typeof(Member), view.getMember()))
                .setGender((Gender)Enum.Parse(typeof(Gender), view.getGender()))
                .setDOB(view.getDOB());
                

            if(string.IsNullOrEmpty(view.getMiddleName()))
            {
                personBuilder
                    .WithNoMiddleName((Prefix)Enum.Parse(typeof(Prefix), view.getTitle()), view.getFirstName(), view.getLastName());

                if(string.IsNullOrEmpty(view.getEmergency()))
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

            member = personBuilder.Build();
            MemberDB.InsertMember(member);
            address = addressBuilder.Build();
            AddressDB.InsertAddress(address);

            if (view.getMember() == "Patient")
            {                
                GPInformationForm gpForm = new GPInformationForm();
                GPInformationPresenter gpPresenter = new GPInformationPresenter(gpForm);
                gpForm.Show();
            }
            else
            {
                ConfirmationForm cForm = new ConfirmationForm();
                ConfirmationPresenter cPresenter = new ConfirmationPresenter(cForm);
                cForm.Show();
            }
        }
    }
}
