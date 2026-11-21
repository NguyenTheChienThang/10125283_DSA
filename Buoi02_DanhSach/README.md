# Buổi 02 – Danh Sách

Họ tên: Nguyễn Thế Chiến Thắng · MSV: 10125283

## Bài đã làm
Bài 1, 2, 3, 4 5



## Cách chạy
```
dotnet run 
=======


## Cách chạy
```
dotnet run --project Buoi02_DeQuy

```

## Kết quả chạy
```

=== Bài 1: Mảng n số nguyên dương ===
Nhập n: 4
a[0] = 10
a[1] = 20
a[2] = 30
a[3] = 40
Danh sách: 10 20 30 40 
Nhập phần tử cần chèn x: 10
Nhập vị trí cần chèn k (0..n): 1
Danh sách sau khi chèn: 10 10 20 30 40 

=== Bài 2: Danh sách nhân viên ===
a. Tổng thực lĩnh tháng của tất cả nhân viên: 51300000
b. Nhân viên có mức lương cơ bản thấp nhất:
NV03 - Trần Thị Bình - Lương CB: 10000000 - Thực lĩnh: 11000000
NV02 - Lê Minh Cường - Lương CB: 10000000 - Thực lĩnh: 12000000
c. Số lượng nhân viên có mức thưởng >= 1200000: 2
d. Danh sách tăng dần theo phòng ban, trùng phòng ban thì giảm dần theo mã NV:
HR | NV02 | Lê Minh Cường | Thực lĩnh: 12000000
IT | NV03 | Trần Thị Bình | Thực lĩnh: 11000000
IT | NV01 | Nguyễn Văn An | Thực lĩnh: 13500000
Sales | NV04 | Phạm Thu Dung | Thực lĩnh: 14800000
e. Cập nhật tăng lương cơ bản tất cả nhân viên lên 5%:
NV01 - Nguyễn Văn An - Lương CB mới: 12600000 - Thực lĩnh mới: 14100000
NV03 - Trần Thị Bình - Lương CB mới: 10500000 - Thực lĩnh mới: 11500000
NV02 - Lê Minh Cường - Lương CB mới: 10500000 - Thực lĩnh mới: 12500000
NV04 - Phạm Thu Dung - Lương CB mới: 14700000 - Thực lĩnh mới: 15500000

=== Bài 3: Ma trận vuông n x n ===
Nhập n (0 <= n < 100): 3
a[0,0] = -2
a[0,1] = 5
a[0,2] = 1
a[1,0] = 4
a[1,1] = 3
a[1,2] = -6
a[2,0] = 8
a[2,1] = 2
a[2,2] = 9
a. Tổng tất cả các phần tử của ma trận: 24
b. Giá trị dương nhỏ nhất của ma trận: 1
c. Tổng các phần tử nằm trên đường chéo phụ: 12
d. Đường chéo chính tăng dần: True

=== Bài 4: Danh sách liên kết đơn (số nguyên dương) ===
Danh sách liên kết đơn ban đầu: 12 5 8 5 20 3 
Nhập x cần đếm và xóa: 12
a. Số lượng phần tử bằng 12: 1
b. Phần tử dương nhỏ nhất: 3
c. Danh sách sau khi xóa 12 xuất hiện đầu tiên: 5 8 5 20 3 

=== Bài 5: Danh sách liên kết đơn l (số nguyên) ===
Danh sách l: -4 0 7 2 -9 11 0 5 
Nhập x cần đếm: 7
a. Phần tử lớn nhất: 11
b. Tổng các phần tử: 12
c. Số lượng số nguyên tố: 4
d. Số âm: 2 | Số bằng 0: 2 | Số dương: 4
e. Số lượng phần tử bằng 7: 1
f. Phần tử dương nhỏ nhất: 2
=======
=== Bài 1: Kiểm tra tính đúng đắn của biểu thức toán học ===
Nhập biểu thức: {}
Biểu thức hợp lệ.

=== Bài 2: Mô phỏng lịch sử trình duyệt web ===
Trang hiện tại: Home
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 1
Nhập URL trang mới: thang
Trang hiện tại: thang
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 3
Không thể chuyển tiếp (Forward rỗng).
Trang hiện tại: thang
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 2
Trang hiện tại: Home
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 2
Không thể quay lại (Back rỗng).
Trang hiện tại: Home
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 3
Trang hiện tại: thang
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 2
Trang hiện tại: Home
1. Truy cập trang mới | 2. Back | 3. Forward | 0. Thoát
Chọn: 0

=== Bài 3: Mô phỏng quá trình thực thi chương trình ===
Gọi: Main() [return: exit]
Gọi: TinhTong(a=3, b=5) [return: Main]
Gọi: CongHaiSo(x=3, y=5) [return: TinhTong]
Kết thúc và trả về từ: CongHaiSo(x=3, y=5) [return: TinhTong]
Kết thúc và trả về từ: TinhTong(a=3, b=5) [return: Main]
Kết thúc và trả về từ: Main() [return: exit]

=== Bài 4: Mô phỏng hệ thống in ấn ===
Đang xử lý in: TaiLieu_1.pdf
Đang xử lý in: BaoCao_2.docx
Đang xử lý in: Slide_3.pptx

=== Bài 5: Mô phỏng đường truyền dữ liệu ===
Nhận và xử lý: Packet_1: Hello
Nhận và xử lý: Packet_2: Data
Nhận và xử lý: Packet_3: End

```
