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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ClinicQ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageDetails : Page
    {
        public PageDetails()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
//TODO: the user fills their details in on this page and clicks OK 
//and gets taken back to the main page where their details are now displayed.

//Code for adding details to queues and listboxes:
            ////Patient Name
            //QPatientName.Enqueue(t1.Text);
            ////
            //lbxPatientName.Items.Clear();//clears the textbox so that it doesn't display duplicates of the queue.
            //foreach (var f in QPatientName)//each value in Q
            //{
            //    lbxPatientName.Items.Add(String.Format("{0}", f));//add to listbox.
            //}
            ////Phone Number
            //QPhoneNumber.Enqueue(t2.Text);
            ////
            //lbxPhoneNumber.Items.Clear();//clears the textbox so that it doesn't display duplicates of the queue.
            //foreach (var f in QPhoneNumber)//each value in Q
            //{
            //    lbxPhoneNumber.Items.Add(String.Format("{0}", f));//add to listbox.
            //}
            ////Address
            //QAddress.Enqueue(t3.Text);
            ////
            //lbxAddress.Items.Clear();//clears the textbox so that it doesn't display duplicates of the queue.
            //foreach (var f in QAddress)//each value in Q
            //{
            //    lbxAddress.Items.Add(String.Format("{0}", f));//add to listbox.
            //}
            ////