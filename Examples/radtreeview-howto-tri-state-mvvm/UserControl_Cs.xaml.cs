
#region radtreeview-how-to-tri-state-0
using System;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;
using System.Linq;

namespace TreeViewMVVMCheckBoxSample.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        private string _name;
        private bool? _isChecked;

        private ObservableCollection<CategoryViewModel> _subCategories = null;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public bool? IsChecked
        {
            get
            {
                return this._isChecked;
            }
            set
            {
                if (this._isChecked != value)
                {
                    this._isChecked = value;
                    OnPropertyChanged("IsChecked");
                }
            }
        }

        public ObservableCollection<CategoryViewModel> SubCategories
        {
            get
            {
                if (this._subCategories == null)
                {
                    this._subCategories = new ObservableCollection<CategoryViewModel>();
                }
                return this._subCategories;
            }
        }
    }
}
#endregion

#region radtreeview-how-to-tri-state-1
public bool? IsChecked
{
	get
	{
		return this._isChecked;
	}
	set
	{
		if (this._isChecked != value)
		{
			this._isChecked = value;
			this.UpdateCheckState();
			OnPropertyChanged("IsChecked");
		}
	}
}

private void UpdateCheckState()
{
	// update all children:
	if (this.SubCategories.Count != 0)
	{
		this.UpdateChildrenCheckState();
	}
	//update parent item
	if (this.parentItem != null)
	{
		bool? parentIsChecked = this.parentItem.DetermineCheckState();
		this.parentItem.IsChecked = parentIsChecked;
	}
}
#endregion
#region radtreeview-how-to-tri-state-2
private bool reentrancyCheck = false;
public bool? IsChecked
{
    get
    {
        return this._isChecked;
    }
    set
    {
        if (this._isChecked != value)
        {
            if (reentrancyCheck)
                return;
            this.reentrancyCheck = true;
            this._isChecked = value;
            this.UpdateCheckState();
            OnPropertyChanged("IsChecked");
            this.reentrancyCheck = false;
        }
    }
}
#endregion
#region radtreeview-how-to-tri-state-3
using System;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;
using System.Linq;

namespace TreeViewMVVMCheckBoxSample.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        private string _name;
        private bool? _isChecked;
        private bool reentrancyCheck = false;
        private CategoryViewModel parentItem;

        private ObservableCollection<CategoryViewModel> _subCategories = null;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public bool? IsChecked
        {
            get
            {
                return this._isChecked;
            }
            set
            {
                if (this._isChecked != value)
                {
                    if (reentrancyCheck)
                        return;
                    this.reentrancyCheck = true;
                    this._isChecked = value;
                    this.UpdateCheckState();
                    OnPropertyChanged("IsChecked");
                    this.reentrancyCheck = false;
                }
            }
        }

        public ObservableCollection<CategoryViewModel> SubCategories
        {
            get
            {
                if (this._subCategories == null)
                {
                    this._subCategories = new ObservableCollection<CategoryViewModel>();
                }
                return this._subCategories;
            }
        }

        public CategoryViewModel(CategoryViewModel parent)
        {
            this.parentItem = parent;
        }

        private void UpdateCheckState()
        {
            // update all children:
            if (this.SubCategories.Count != 0)
            {
                this.UpdateChildrenCheckState();
            }
            //update parent item
            if (this.parentItem != null)
            {
                bool? parentIsChecked = this.parentItem.DetermineCheckState();
                this.parentItem.IsChecked = parentIsChecked;

            }
        }

        private void UpdateChildrenCheckState()
        {
            foreach (var item in this.SubCategories)
            {
                if (this.IsChecked != null)
                {
                    item.IsChecked = this.IsChecked;
                }
            }
        }

        private bool? DetermineCheckState()
        {
            bool allChildrenChecked = this.SubCategories.Count(x => x.IsChecked == true) == this.SubCategories.Count;
            if (allChildrenChecked)
            {
                return true;
            }

            bool allChildrenUnchecked = this.SubCategories.Count(x => x.IsChecked == false) == this.SubCategories.Count;
            if (allChildrenUnchecked)
            {
                return false;
            }

            return null;
        }
    }
}
#endregion

#region radtreeview-how-to-tri-state-4
using System;
using System.Collections.ObjectModel;

namespace TreeViewMVVMCheckBoxSample.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<CategoryViewModel> Categories { get; set; }

        public MainViewModel()
        {
            Categories = new ObservableCollection<CategoryViewModel>();

            CategoryViewModel beverages = new CategoryViewModel(null);
            beverages.Name = "Bevereges";

            for (int i = 0; i < 5; i++)
            {
                CategoryViewModel prod = new CategoryViewModel(beverages)
                {
                    Name = String.Format("Beverage {0}", i),
                    IsChecked = false
                };

                for (int j = 0; j < 3; j++)
                {
                    prod.SubCategories.Add(new CategoryViewModel(prod)
                {
                    Name = String.Format("SubBeverage {0}.{1}", i, j),
                    IsChecked = false
                });
                }
                beverages.SubCategories.Add(prod);
            }
            Categories.Add(beverages);


            CategoryViewModel confections = new CategoryViewModel(null);
            confections.Name = "Confections";
            for (int i = 0; i < 7; i++)
            {
                confections.SubCategories.Add(new CategoryViewModel(confections)
                {
                    Name = String.Format("Confection {0}", i),
                    IsChecked = false
                });
            }
            Categories.Add(confections);

            CategoryViewModel condiments = new CategoryViewModel(null);
            condiments.Name = "Condiments";
            for (int i = 0; i < 3; i++)
            {
                condiments.SubCategories.Add(new CategoryViewModel(condiments)
                {
                    Name = String.Format("Condiment {0}", i),
                    IsChecked = false
                });
            }
            Categories.Add(condiments);
        }
    }
}
#endregion
