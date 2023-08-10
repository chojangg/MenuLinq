using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLinq
{
    public partial class Form1 : Form
    {
        static private List<Menu> menus = new List<Menu>()
        {
            new Menu() { Name = "까르보나라", Type = "Food", Price = 9800, Star = 4.3 },
            new Menu() { Name = "파스타", Type = "Food", Price = 10000, Star = 4.5 },
            new Menu() { Name = "스테이크", Type = "Food", Price = 13000, Star = 4.4 },
            new Menu() { Name = "피자", Type = "Food", Price = 11000, Star = 4 },
            new Menu() { Name = "햄버거", Type = "Food", Price = 5300, Star = 3.9 },
            new Menu() { Name = "감자튀김", Type = "Food", Price = 5500, Star = 3.8 },
            new Menu() { Name = "샐러드", Type = "Food", Price = 7800, Star = 3.5 },
            new Menu() { Name = "스프", Type = "Food", Price = 8500, Star = 3.9 },
            new Menu() { Name = "리조또", Type = "Food", Price = 8900, Star = 4.1 },
            new Menu() { Name = "치킨카레", Type = "Food", Price = 9500, Star = 3.8 },
            new Menu() { Name = "바게트", Type = "Food", Price = 1300, Star = 2.5 },
            new Menu() { Name = "모닝빵", Type = "Food", Price = 1000, Star = 3.6 },
            new Menu() { Name = "연어샐러드", Type = "Food", Price = 10500, Star = 5.0 },
            new Menu() { Name = "볶음밥", Type = "Food", Price = 8300, Star = 3.4 },
            new Menu() { Name = "오믈렛", Type = "Food", Price = 8500, Star = 4.5 },
            new Menu() { Name = "탄산수", Type = "Drink", Price = 1500, Star = 2.7 },
            new Menu() { Name = "딸기주스", Type = "Drink", Price = 1700, Star = 4.8 },
            new Menu() { Name = "오렌지주스", Type = "Drink", Price = 1700, Star = 4.5 },
            new Menu() { Name = "사이다", Type = "Drink", Price = 2000, Star = 4.3 },
            new Menu() { Name = "콜라", Type = "Drink", Price = 2000, Star = 4.2 },
            new Menu() { Name = "맥주", Type = "Drink", Price = 4500, Star = 4.0 },
            new Menu() { Name = "와인", Type = "Drink", Price = 5500, Star = 4.5 },
        };
        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
