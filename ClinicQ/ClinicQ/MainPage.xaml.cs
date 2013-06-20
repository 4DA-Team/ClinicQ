using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ClinicQ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        Queue<string> QPatientName = new Queue<string>();//queue for storing patient names in.
        Queue<string> QPhoneNumber = new Queue<string>();
        Queue<string> QAddress = new Queue<string>();

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        /// <summary>
        /// Clicking this button removes the patient at the head of the queue and 
        /// updated the listboxes so that they displays the queues without the patient 
        /// that has been removed.
        /// </summary>
        private void btnRemovePatient_Click(object sender, RoutedEventArgs e)
        {
            //Patient Name
            QPatientName.Dequeue();//removes the patient at the head of the queue.
            //
            lbxPatientName.Items.Clear();//clears the textbox so that it doesn't display duplicates of the queue.
            foreach (var f in QPatientName)//each value in Q
            {
                lbxPatientName.Items.Add(String.Format("{0}", f));//add to listbox.
            }
            //Phone Number
            QPhoneNumber.Dequeue();//removes the patient at the head of the queue.
            //
            lbxPhoneNumber.Items.Clear();//clears the textbox so that it doesn't display duplicates of the queue.
            foreach (var f in QPhoneNumber)//each value in Q
            {
                lbxPhoneNumber.Items.Add(String.Format("{0}", f));//add to listbox.
            }
            //Address
            QAddress.Dequeue();//removes the patient at the head of the queue.
            //
            lbxAddress.Items.Clear();//clears the textbox so that it doesn't display duplicates of the queue.
            foreach (var f in QAddress)//each value in Q
            {
                lbxAddress.Items.Add(String.Format("{0}", f));//add to listbox.
            }
            //
        }

        private void btnAddPatient_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Make a new form to display when the user clicks on the add 
            //patient button with field for the user to fill their details in
            this.Frame.Navigate(typeof(PageDetails));                        
        }
    }
}
//TEAM NOTES:
//
//Leave notes like this: //Note:
//Note: Mark things that still need to be done like this: //TODO: 
//Note: Mark problems you encounter like this: //!an error occurs when...
//Note: Instead of deleting code that someone else wrote, comment it out, 
//it might be usefull later on and it gives that person a reference point as to how the code works afterwards. 
//
//TODO:
//
//TODO: make a queue that stores the people at a clinic's position.
//TODO: find a way to make the queue fair. if someone was a the queue the day before, they have higher 
//precedence than someone who just got there, but if a person was there the previous day but only arrives in the
//middle of today they should be placed in the middle of the queue. Something like that, we will need to think of 
//an algorithim.
//TODO: Make a form where patient details can be filled in as easily as possible.
//TODO: Make the app look professional.
//TODO: add animation(jackson your department.)
//TODO: make the app user friendly. It should not interfere with the working of the clinic.
//
//Note:
//
//Note: I think we should make the app work like taking a number, when a patient enters the clinic, they should 
//give their name and be given a place in the queue.
//
//! 