# Quản Lý Quán Ăn - Windows Forms C#

## Mô tả dự án
Dự án là một **ứng dụng quản lý quán ăn** được phát triển bằng **C# WinForms** kết hợp **SQL Server**.  
Ứng dụng cho phép:  

- Đăng nhập và phân quyền truy cập.  
- Quản lý danh mục món ăn, thực đơn, bàn ăn và hóa đơn.  
- Thêm, sửa, xóa và làm mới dữ liệu trực tiếp trên **DataGridView**.  
- Giao diện trực quan, thân thiện với người dùng.  

## Công nghệ sử dụng
- **Ngôn ngữ lập trình:** C# (.NET Framework)  
- **Giao diện:** Windows Forms  
- **Cơ sở dữ liệu:** SQL Server (ADO.NET)  
- **IDE:** Visual Studio  

## Tính năng chính
1. **Đăng nhập**
   - Kiểm tra username và password từ cơ sở dữ liệu.  
   - Ẩn/hiện mật khẩu khi click vào icon.
   - ![Login](Ảnh%20chụp%20màn%20hình%202025-12-01%20151006.png)

2. **Quản lý danh mục món ăn**
   - Thêm, sửa, xóa danh mục món ăn.
   - Dữ liệu hiển thị trực tiếp trên DataGridView.
   - Minh họa giao diện:
   ![Danh mục món ăn](images/danhmuc.png)

3. **Quản lý thực đơn**
   - Thêm, sửa, xóa món ăn trong thực đơn.
   - Chọn loại món từ danh mục.
   - Minh họa giao diện:
   ![Thực đơn](images/thucdon.png)

4. **Quản lý bàn ăn**
   - Thêm, sửa, xóa thông tin bàn ăn.
   - Làm mới dữ liệu dễ dàng.
   - Minh họa giao diện:
   ![Bàn ăn](images/banan.png)

5. **Quản lý hóa đơn**
   - Thêm món vào hóa đơn với số lượng.
   - Xem hóa đơn trực quan.
   - Minh họa giao diện:
   ![Hóa đơn](images/hoadon.png)

6. **Giao diện**
   - Sử dụng nhiều **Panel** để quản lý từng module.
   - Ẩn/hiện panel theo module để tăng trải nghiệm người dùng.

## Hướng dẫn sử dụng
1. Mở **Visual Studio**, tải dự án về.  
2. Chỉnh sửa **connection string** để kết nối với SQL Server:  
   ```csharp
   private string connect = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=MonAn;Integrated Security=True;";
