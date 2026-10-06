lab3: 
    main --> làm 2 bài 3,4
    bai 3: nhạc, read folder file
    bài 4: menustrip, BT english

lab4:
    main: Dock( Panel, Spliter, Groupbox, DataGridView)
          Class CSDL
          DataGridView( CellClick)
          Quy tắc: Form Load --> False chi tiêt                       + False sửa xóa
                   Tìm kiếm  --> đổi DataSource                       + False sửa xóa
                   CellCLick --> Hiển thị chi tiết                    + True  sửa xóa
                   Thêm      --> Xóa chi tiết cũ + True chi tiết      + False sửa xóa
                   Sửa       --> 
                   Xóa       -->
                   Lưu       --> Kiểm tra từng field + chỉ lưu khi Thêm/Sửa/Xóa bật
                   Hủy       --> True Thêm + False chi tiết           + False Sửa Xóa
          CSDL: cách tạo table ở Program, data ở DataProcessing                                                         <CSDL 4>
          Lỗi gặp phải: Không khớp kiểu Date
    main-cleancode: xóa commend linh tinh (X)

online4:
    csdl: kết nối CSDL = event form load                                                                                <csdl 1>
    csdl-CRUD: kết nối CSDL = gọi hàm( cho code vào hàm rồi gọi),                                                       <csdl 2>
               dgv( SelectionMode, MultiSelect, ReadOnly, AllowUserToAddRows)
               button CRUD, CellClick --> AI'code

online5:
    project-video1: kết nối csdl                                                                                        <csdl 5>
                    class function
    project-video2: 

class7:
    main: tạo giao diện
    main-classcsdl: class tương tác data( openConnect, closeConnect, ReadData, ChangeData)                              <csdl 3>
                    event form load: đọc data
    
    
