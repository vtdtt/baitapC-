create database htthi;
go
USE htthi;
GO

CREATE TABLE dethi
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaDe VARCHAR(20) NOT NULL UNIQUE,
    TenDe NVARCHAR(100) NOT NULL,
    MonId INT NOT NULL,
    ThoiGian INT NOT NULL,

    CONSTRAINT FK_dethi_monthi
        FOREIGN KEY (MonId) REFERENCES monthi(Id),

    CONSTRAINT CK_dethi_ThoiGian
        CHECK (ThoiGian > 0)
);
GO

create table monthi
(
id int IDENTITY(1,1) primary key,
tenmon nvarchar(20) 
);
insert into monthi (tenmon) values
(N'Triết học Mác Lê-nin'),
(N'Toán giải tích 1'),
(N'Toán giải tích 2');
create table cauhoi
(   
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MonId INT NOT NULL,
    NoiDung NVARCHAR(500) NOT NULL,
    DapAnA NVARCHAR(200),
    DapAnB NVARCHAR(200),
    DapAnC NVARCHAR(200),
    DapAnD NVARCHAR(200),
    DapAnDung CHAR(1),
    FOREIGN KEY (MonId) REFERENCES monthi(Id)
);
insert into cauhoi (MonId, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) values
(
    1,
    N'Chủ nghĩa Mác nói chung, triết học Mác nói riêng ra đời vào những năm nào của thế kỷ XIX ?',
    N'Những năm 30 của thế kỷ XIX.',
    N'Những năm 40 của thế kỷ XIX.',
    N'Những năm 50 của thế kỷ XIX.',
    N'Những năm 20 của thế kỷ XIX.',
    'B'
),
(
    1,
    N'Vật chất theo quan điểm của triết học Mác - Lênin là gì ?',
    N'Tồn tại khách quan, độc lập với ý thức',
    N'Tổng hợp các ý niệm của con người',
    N'Những gì con người có thể nhìn thấy',
    N'Một dạng đặc biệt của ý thức',
    'A'
);
insert into cauhoi (MonId, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) values
(
    2,
    N'Hệ số góc tiếp tuyến với đường cong 𝑦 = (cos x)^x tại x = 0 là?',
    N'k = 1',
    N'k = - 1',
    N'k = ∞',
    N'k = 0',
    'D'
),
(
    2,
    N'Đạo hàm của hàm số y = x² tại x = 1 bằng bao nhiêu?',
    N'1',
    N'2',
    N'3',
    N'4',
    'B'
);


INSERT INTO dethi (MaDe, TenDe, MonId, ThoiGian)
VALUES
('DT01', N'Đề thi Triết số 1', 1, 60),
('DT02', N'Đề thi Toán giải tích 1 - Số 1', 2, 90),
('DT03', N'Đề thi Toán giải tích 2 - Số 1', 3, 90);
GO

insert into cauhoi (MonId, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) values
(
    3,
    N'Giá trị của tích phân kép ∬_D (x + y) dA trên miền D: 0 ≤ x ≤ 1, 0 ≤ y ≤ 1 là?',
    N'0',
    N'1',
    N'2',
    N'1/2',
    'B'
),
(
    3,
    N'Tích phân không xác định ∫ x cos(x²) dx bằng?',
    N'sin(x²) + C',
    N'1/2 sin(x²) + C',
    N'cos(x²) + C',
    N'-1/2 sin(x²) + C',
    'B'
);
select * from cauhoi 
select *from monthi
select *from dethi
