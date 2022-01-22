using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace HabitApp.Pages
{
    public class ViewHabitsModel : PageModel
    {   [BindProperty]
        public IEnumerable<HabitModel> HabitDataModels { get; set; }

        [BindProperty]
        public UpdateHabitModel HabitModel { get; set; }

        public void OnGet()
        {


            

        }

   

        public void OnPost() 
        {
            if (HabitModel.habitDescription == "delete")
            {
                IViewHabit viewHabitService = new ViewHabitImpl();
                viewHabitService.deleteHabit(ObjectId.Parse(HabitModel.habitId.ToString()));
                
                HabitDataModels = viewHabitService.getHabitModelsById(ObjectId.Parse(HabitModel.habitId));
            }
            else 
            {
                IViewHabit viewHabitService = new ViewHabitImpl();
                HabitDataModels = viewHabitService.getHabitModelsById(ObjectId.Parse(HabitModel.habitId));
            }

            
        }


    }
}
