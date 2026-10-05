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
          CSDL: table ở Program, data ở DataProcessing

online4:
    csdl: kết nối CSDL = event form load
    csdl-CRUD: kết nối CSDL = gọi hàm( cho code vào hàm rồi gọi), 
               dgv( SelectionMode, MultiSelect, ReadOnly, AllowUserToAddRows)
               button CRUD, CellClick --> AI'code

online5:
    project --> class tương tác csdl + nhập ảnh + 6 nút + tìm kiếm                                                    : chưa làm
    project-csdl: chưa code j

class7:
    main: tạo giao diện
    main-classcsdl: class tương tác data( openConnect, closeConnect, ReadData, ChangeData)
                    event form load: đọc data
    
    
