namespace WebApp.Pages.User;

public partial class Account
{
    public List<MenuItem> MenuItems { get; set; }

    public class MenuItem
    {
        public string Text { get; set; }
        public ISvgIcon Icon { get; set; }
        public string Url { get; set; }
        public List<MenuItem> Items { get; set; }
    }

    public List<BreadcrumbItem> Items { get; set; }

    protected override void OnInitialized()
    {
        Items = new List<BreadcrumbItem>
        {
            new() { Text = "Home", Icon = SvgIcon.Home },
            new() { Text = "Account" },
        };


        MenuItems = new List<MenuItem>()
        {
            new MenuItem()
            {
                Text = "Thông tin tài khoản",
                Icon = SvgIcon.User, // Example icon, replace with appropriate icon
                Url = "/account-info"
            },
            new MenuItem()
            {
                Text = "Thông báo của tôi",
                Icon = SvgIcon.Bell, // Example icon
                Url = "/notifications"
            },
            new MenuItem()
            {
                Text = "Quản lý đơn hàng",
                Icon = SvgIcon.CaretAltDown, // Example icon
                Url = "/orders"
            },
            new MenuItem()
            {
                Text = "Quản lý đổi trả",
                Icon = SvgIcon.CaretAltDown, // Example icon
                Url = "/returns"
            },
            new MenuItem()
            {
                Text = "Sổ địa chỉ",
                Icon = SvgIcon.MapMarker, // Example icon
                Url = "/address-book"
            },
            new MenuItem()
            {
                Text = "Thông tin thanh toán",
                Icon = SvgIcon.CaretAltDown, // Example icon
                Url = "/payment-info"
            }
        };
    }

    public class BreadcrumbItem
    {
        public string Text { get; set; }
        public ISvgIcon Icon { get; set; }
        public string Url { get; set; }
    }
}