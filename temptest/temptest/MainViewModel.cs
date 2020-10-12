using System;
using System.Collections.Generic;
using System.Text;

namespace temptest
{
    public class MainViewModel:BaseViewModel
    {
        public MainViewModel()
        {
            DataList = new List<TestData>
            {
                new TestData
                {
                    Icon="smile",
                    Title="Test title 1",
                    SubTitle="Sub title 1",
                },
                new TestData
                {
                    Icon="smile",
                    Title="Test title 2",
                    SubTitle="Sub title 2",
                    RightText="£88"
                },
                new TestData
                {
                    Title="Test title 3",
                },
                new TestData
                {
                    Icon="smile",
                    Title="Test title 4",
                },

            };
        }

        private List<TestData> _dataList;

        public List<TestData> DataList
        {
            get { return _dataList; }
            set
            {
                _dataList = value;
                OnPropertyChanged();
            }
        }

    }

    public class TestData
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string RightText { get; set; }
    }
}
