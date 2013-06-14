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
    public sealed partial class MainPage : Page
    {
        public MainPage()
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