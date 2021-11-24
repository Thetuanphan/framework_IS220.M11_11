/*create database LapTop;
use laptop;*/
------------- Table ---------------

use LapTop;

/*==============================================================*/
/* Table: TAIKHOAN                 		                        */
/*==============================================================*/
create table TAIKHOAN
(
   TENDANGNHAP          varchar(20) not null,
   MATKHAU              varchar(20) not null,
   QUYEN                varchar(20) not null,
   primary key (TENDANGNHAP)
) default charset = utf8mb4;

/*==============================================================*/
/* Table: NHANVIEN                                        */
/*==============================================================*/
create table NHANVIEN
(
   MANV                 char(6) not null,
   TENDANGNHAP          varchar(20) not null,
   TENNV                varchar(50),
   NGAYSINH             date,
   GIOITINH             char(5),
   CHUCVU               varchar(10),
   DIACHI               varchar(100),
   NGAYVL               date,
   SODT                 char(12),
   primary key (MANV)
) default charset = utf8mb4;

/*==============================================================*/
/* Table: KHACHHANG                                       */
/*==============================================================*/
create table KHACHHANG
(
   MAKH                 char(6) not null,
   TENDANGNHAP          varchar(10) not null,
   TENKH                varchar(50),
   SODT                 char(12),
   EMAIL                varchar(50),
   GIOITINH             char(5),
   primary key (MAKH)
) default charset = utf8mb4;

/*==============================================================*/
/* Table: SANPHAM                                         */
/*==============================================================*/
create table SANPHAM
(
   MASP                 char(6) not null,
   MANHINH              char(5) not null,
   BOXULY               char(5) not null,
   RAM                  char(5) not null,
   CONGKETNOI           char(5) not null,
   DANHMUC              char(6) not null,
   TENSP                varchar(100),
   SOLUONG              int,
   MAUSAC               varchar(20),
   OCUNG                varchar(200),
   CARDMANHINH          varchar(100),
   DACBIET              varchar(100),
   HDH                  varchar(100),
   THIETKE              varchar(50),
   KICHTHUOC_TRONGLUONG varchar(100),
   WEBCAM               varchar(50),
   PIN                  varchar(50),
   RAMAT                int,
   MOTA                 varchar(200),
   DONGIA               bigint,
   HINHANH              varchar(200),
   primary key (MASP)
)DEFAULT CHARSET=utf8mb4;

/*==============================================================*/
/* Table: BONHORAM                                        */
/*==============================================================*/
create table BONHORAM
(
   MARAM                char(5) not null,
   DUNGLUONGRAM         varchar(50),
   LOAIRAM              varchar(100),
   BUSRAM               varchar(20),
   HOTROTOIDA           varchar(10),
   primary key (MARAM)
) DEFAULT CHARSET=utf8mb4 ;

/*==============================================================*/
/* Table: BOXULY                                          */
/*==============================================================*/
create table BOXULY
(
   MABXL                char(5) not null,
   CONGNGHECPU          varchar(50),
   SONHAN               int,
   SOLUONG              int,
   TOCDOCPU             varchar(20),
   TOCDOTOIDA           varchar(50),
   BONHODEM             varchar(10),
   primary key (MABXL)
) DEFAULT CHARSET=utf8mb4;

/*==============================================================*/
/* Table: CONGKETNOI                                      */
/*==============================================================*/
create table CONGKETNOI
(
   MACKN                char(5) not null,
   CONGGIAOTIEP         varchar(200),
   KETNOIKHONGDAY       varchar(100),
   KHEDOCTHENHO         varchar(20),
   WEBCAM               varchar(50),
   TINHNANGKHAC         varchar(200),
   DENBANPHIM           varchar(10),
   primary key (MACKN)
) DEFAULT CHARSET=utf8mb4;

/*==============================================================*/
/* Table: MANHINH                                         */
/*==============================================================*/
create table MANHINH
(
   MAMH                 char(5) not null,
   KICHTHUOC            varchar(20),
   DOPHANGIAI           varchar(50),
   TANSOQUET            varchar(10),
   CONGNGHEMH           varchar(100),
   CAMUNG               varchar(10),
   primary key (MAMH)
)DEFAULT CHARSET=utf8mb4;

/*==============================================================*/
/* Table: SUKIEN                                          */
/*==============================================================*/
create table SUKIEN
(
   MASK                 char(6) not null,
   TENSK                varchar(50),
   PHANTRAMGIAMGIA      int,
   NGAYBD               date,
   NGAYKT               date,
   primary key (MASK)
) default charset = utf8mb4;


/*==============================================================*/
/* Table: DANHMUCSANPHAM                                  */
/*==============================================================*/
create table DANHMUCSANPHAM
(
   MADM                 char(6) not null,
   TENDM                varchar(50),
   primary key (MADM)
) default charset = utf8mb4;

/*==============================================================*/
/* Table:HOADON                                          */
/*==============================================================*/
create table HOADON
(
   MAHD                 char(6) not null,
   MAKH                 char(6) not null,
   MANV                 char(6) not null,
   MASK                 char(6),
   NGAYHD               date,
   DIACHIGIAOHANG       varchar(100),
   TONGTIEN             int,
   THANHTIEN            int,
   primary key (MAHD)
) default charset = utf8mb4;

/*==============================================================*/
/* Table: CTHD                                            */
/*==============================================================*/
create table CTHD
(
   MAHD                 char(6) not null,
   MASP                 char(6) not null,
   SOLUONG              int,
   primary key (MAHD, MASP)
) default charset = utf8mb4;


/*==============================================================*/
/* KHOA NGOAI                                                   */
/*==============================================================*/

alter table CTHD add constraint FK_CTHD foreign key (MAHD)
      references HOADON (MAHD) on delete restrict on update restrict;

alter table CTHD add constraint FK_CTHD2 foreign key (MASP)
      references SANPHAM (MASP) on delete restrict on update restrict;

alter table HOADON add constraint FK_HD_SK foreign key (MASK)
      references SUKIEN (MASK) on delete restrict on update restrict;

alter table HOADON add constraint FK_LAP foreign key (MANV)
      references NHANVIEN (MANV) on delete restrict on update restrict;

alter table HOADON add constraint FK_THUOC foreign key (MAKH)
      references KHACHHANG (MAKH) on delete restrict on update restrict;

alter table KHACHHANG add constraint FK_CO2 foreign key (TENDANGNHAP)
      references TAIKHOAN (TENDANGNHAP) on delete restrict on update restrict;

alter table NHANVIEN add constraint FK_CO1 foreign key (TENDANGNHAP)
      references TAIKHOAN (TENDANGNHAP) on delete restrict on update restrict;

alter table SANPHAM add constraint FK_THUOC1 foreign key (DANHMUC)
      references DANHMUCSANPHAM (MADM) on delete restrict on update restrict;

alter table SANPHAM add constraint FK_THUOC3 foreign key (RAM)
      references BONHORAM (MARAM) on delete restrict on update restrict;

alter table SANPHAM add constraint FK_THUOC4 foreign key (MANHINH)
      references MANHINH (MAMH) on delete restrict on update restrict;

alter table SANPHAM add constraint FK_THUOC5 foreign key (BOXULY)
      references BOXULY (MABXL) on delete restrict on update restrict;

alter table SANPHAM add constraint FK_THUOC6 foreign key (CONGKETNOI)
      references CONGKETNOI (MACKN) on delete restrict on update restrict;

commit;

/*------------------- AUTO ID --------------------------*/

/*----- AUTOID_KHACHHANG ----*/

DROP FUNCTION IF EXISTS AUTO_IDKH
DELIMITER $$
CREATE FUNCTION AUTO_IDKH()
RETURNS VARCHAR(6)
DETERMINISTIC
BEGIN
	DECLARE MAKHNEW VARCHAR(6);
    declare ID VARCHAR(4);
	IF (SELECT COUNT(MAKH) FROM KHACHHANG) = 0 THEN
		SET MAKHNEW = 'KH0001';
	ELSE
		SELECT MAX(RIGHT(MAKH, 4)) INTO ID from khachhang;
			if ID >= 0 and ID < 9 THEN 
				set MAKHNEW = CONCAT('KH000',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
			IF ID >= 9 and ID < 99 THEN
				SET MAKHNEW = CONCAT('KH00',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
            IF ID >= 99 and ID < 999 THEN
				SET MAKHNEW = CONCAT('KH0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
            IF ID >= 999 THEN
				SET MAKHNEW = CONCAT('KH',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));     
			end if;
	end if;
	RETURN (MAKHNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_KH
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_KH
    BEFORE INSERT
    ON KHACHHANG FOR EACH ROW
BEGIN
	SET NEW.MAKH = AUTO_IDKH();
END$$    
DELIMITER ;

/*----- AUTOID_NHANVIEN ----*/

DROP FUNCTION IF EXISTS AUTO_IDNV
DELIMITER $$
CREATE FUNCTION AUTO_IDNV()
RETURNS VARCHAR(6)
DETERMINISTIC
BEGIN
	DECLARE MANVNEW VARCHAR(6);
    declare ID VARCHAR(4);
	IF (SELECT COUNT(MANV) FROM NHANVIEN) = 0 THEN
		SET MANVNEW = 'NV0001';
	ELSE
		SELECT MAX(RIGHT(MANV, 4)) INTO ID from NHANVIEN;
			if ID >= 0 and ID < 9 THEN 
				set MANVNEW = CONCAT('NV000',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
			IF ID >= 9 and ID < 99 THEN
				SET MANVNEW = CONCAT('NV00',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			END IF;
            IF ID >= 99 and ID < 999 THEN
				SET MANVNEW = CONCAT('NV0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
				END IF;
			IF ID >= 999 THEN
				SET MANVNEW = CONCAT('NV',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
				END IF;
			
	end if;
	RETURN (MANVNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_NV
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_NV
    BEFORE INSERT
    ON NHANVIEN FOR EACH ROW
BEGIN
	SET NEW.MANV = AUTO_IDNV();
END$$    
DELIMITER ;

/*----- AUTOID_BONHORAM ----*/

DROP FUNCTION IF EXISTS AUTO_IDRAM
DELIMITER $$
CREATE FUNCTION AUTO_IDRAM()
RETURNS VARCHAR(5)
DETERMINISTIC
BEGIN
	DECLARE MARAMNEW VARCHAR(5);
    declare ID VARCHAR(2);
	IF (SELECT COUNT(MARAM) FROM BONHORAM) = 0 THEN
		SET MARAMNEW = 'RAM01';
	ELSE
		SELECT MAX(RIGHT(MARAM, 2)) INTO ID from BONHORAM;
			if ID >= 0 and ID < 9 THEN 
				set MARAMNEW = CONCAT('RAM0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			ELSE IF ID >= 9 THEN
					SET MARAMNEW = CONCAT('RAM',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
				 END IF;
            end if;
	end if;
	RETURN (MARAMNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_RAM
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_RAM
    BEFORE INSERT
    ON BONHORAM FOR EACH ROW
BEGIN
	SET NEW.MARAM = AUTO_IDRAM();
END$$    
DELIMITER ;

/*----- AUTOID_BOXULY ----*/

DROP FUNCTION IF EXISTS AUTO_IDBXL
DELIMITER $$
CREATE FUNCTION AUTO_IDBXL()
RETURNS VARCHAR(5)
DETERMINISTIC
BEGIN
	DECLARE MABXLNEW VARCHAR(5);
    declare ID VARCHAR(2);
	IF (SELECT COUNT(MABXL) FROM BOXULY) = 0 THEN
		SET MABXLNEW = 'BXL01';
	ELSE
		SELECT MAX(RIGHT(MABXL, 2)) INTO ID from BOXULY;
			if ID >= 0 and ID < 9 THEN 
				set MABXLNEW = CONCAT('BXL0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			ELSE IF ID >= 9 THEN
					SET MABXLNEW = CONCAT('BXL',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
				 END IF;
            end if;
	end if;
	RETURN (MABXLNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_BXL
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_BXL
    BEFORE INSERT
    ON BOXULY FOR EACH ROW
BEGIN
	SET NEW.MABXL = AUTO_IDBXL();
END$$    
DELIMITER ;

/*----- AUTOID_CONGKETNOI ----*/

DROP FUNCTION IF EXISTS AUTO_IDCKN
DELIMITER $$
CREATE FUNCTION AUTO_IDCKN()
RETURNS VARCHAR(5)
DETERMINISTIC
BEGIN
	DECLARE MACKNNEW VARCHAR(5);
    declare ID VARCHAR(2);
	IF (SELECT COUNT(MACKN) FROM CONGKETNOI) = 0 THEN
		SET MACKNNEW = 'CKN01';
	ELSE
		SELECT MAX(RIGHT(MACKN, 2)) INTO ID from CONGKETNOI;
			if ID >= 0 and ID < 9 THEN 
				set MACKNNEW = CONCAT('CKN0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			ELSE IF ID >= 9 THEN
					SET MACKNNEW = CONCAT('CKN',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
				 END IF;
            end if;
	end if;
	RETURN (MACKNNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_CKN
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_CKN
    BEFORE INSERT
    ON CONGKETNOI FOR EACH ROW
BEGIN
	SET NEW.MACKN = AUTO_IDCKN();
END$$    
DELIMITER ;

/*----- AUTOID_MANHINH ----*/

DROP FUNCTION IF EXISTS AUTO_IDMH
DELIMITER $$
CREATE FUNCTION AUTO_IDMH()
RETURNS VARCHAR(5)
DETERMINISTIC
BEGIN
	DECLARE MAMHNEW VARCHAR(5);
    declare ID VARCHAR(3);
	IF (SELECT COUNT(MAMH) FROM MANHINH) = 0 THEN
		SET MAMHNEW = 'MH001';
	ELSE
		SELECT MAX(RIGHT(MAMH, 3)) INTO ID from MANHINH;
			if ID >= 0 and ID < 9 THEN 
				set MAMHNEW = CONCAT('MH00',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			 END IF;
			IF ID >= 9 and ID < 99 THEN
					SET MAMHNEW = CONCAT('MH0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			END IF;
			IF ID >= 99 THEN
					SET MAMHNEW = CONCAT('MH',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			END IF;
	end if;
	RETURN (MAMHNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_MH
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_MH
    BEFORE INSERT
    ON MANHINH FOR EACH ROW
BEGIN
	SET NEW.MAMH = AUTO_IDMH();
END$$    
DELIMITER ;sanpham

/*----- AUTOID_DANHMUCSANPHAM ----*/

DROP FUNCTION IF EXISTS AUTO_IDDMSP
DELIMITER $$
CREATE FUNCTION AUTO_IDDMSP()
RETURNS VARCHAR(6)
DETERMINISTIC
BEGIN
	DECLARE MADMNEW VARCHAR(6);
    declare ID VARCHAR(4);
	IF (SELECT COUNT(MADM) FROM DANHMUCSANPHAM) = 0 THEN
		SET MADMNEW = 'DM0001';
	ELSE
		SELECT MAX(RIGHT(MADM, 4)) INTO ID from DANHMUCSANPHAM;
			if ID >= 0 and ID < 9 THEN 
				set MADMNEW = CONCAT('DM000',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
            if ID >= 9 and ID < 99 THEN 
				set MADMNEW = CONCAT('DM00',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
            if ID >= 99 and ID < 999 THEN 
				set MADMNEW = CONCAT('DM0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
			IF ID >= 999 THEN
					SET MADMNEW = CONCAT('DM',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			END IF;
           
	end if;
	RETURN (MADMNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_DMSP
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_DMSP
    BEFORE INSERT
    ON DANHMUCSANPHAM FOR EACH ROW
BEGIN
	SET NEW.MADM = AUTO_IDDMSP();
END$$    
DELIMITER ;

/*----- AUTOID_SANPHAM ----*/

DROP FUNCTION IF EXISTS AUTO_IDSP
DELIMITER $$
CREATE FUNCTION AUTO_IDSP()
RETURNS VARCHAR(6)
DETERMINISTIC
BEGIN
	DECLARE MASPNEW VARCHAR(6);
    declare ID VARCHAR(4);
	IF (SELECT COUNT(MASP) FROM SANPHAM) = 0 THEN
		SET MASPNEW = 'SP0001';
	ELSE
		SELECT MAX(RIGHT(MASP, 4)) INTO ID from SAPPHAM;
			If ID >= 0 and ID < 9 THEN 
				set MASPNEW = CONCAT('SP000',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
            if ID >= 9 and ID < 99 THEN 
				set MASPNEW = CONCAT('SP00',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
            if ID >= 99 and ID < 999 THEN 
				set MASPNEW = CONCAT('SP0',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			end if;
			IF ID >= 999 THEN
					SET MASPNEW = CONCAT('SP',CONVERT((CONVERT(ID, UNSIGNED) + 1),CHAR));
			END IF;
	end if;
	RETURN (MASPNEW);
END$$ 
DELIMITER ;

DROP TRIGGER IF EXISTS trigger_AUTO_ID_SP
DELIMITER $$
CREATE TRIGGER trigger_AUTO_ID_SP
    BEFORE INSERT
    ON SANPHAM FOR EACH ROW
BEGIN
	SET NEW.MASP = AUTO_IDSP();
END$$    
DELIMITER ;
/*------------------- TRIGGER ---------------------------*/
create trigger CLR_TRIGGER__CODE_KHACHHANG on _CODE_KHACHHANG  insert as
external name %Assembly.GeneratedName%.
go


create trigger TD__CODE_KHACHHANG on _CODE_KHACHHANG for delete as
begin
    declare
       @numrows  int,
       @errno    int,
       @errmsg   varchar(255)

    select  @numrows = @@rowcount
    if @numrows = 0
       return

    /*  Cannot delete parent "_CODE_KHACHHANG" if children still exist in "_CODE_HOADON"  */
    if exists (select 1
               from   _CODE_HOADON t2, deleted t1
               where  t2.MAKH = t1.MAKH)
       begin
          select @errno  = 50006,
                 @errmsg = 'Children still exist in "_CODE_HOADON". Cannot delete parent "_CODE_KHACHHANG".'
          goto error
       end


    return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger TI__CODE_KHACHHANG on _CODE_KHACHHANG for insert as
begin
    declare
       @maxcard  int,
       @numrows  int,
       @numnull  int,
       @errno    int,
       @errmsg   varchar(255)

    select  @numrows = @@rowcount
    if @numrows = 0
       return

    /*  Parent "_CODE_TAIKHOAN" must exist when inserting a child in "_CODE_KHACHHANG"  */
    if update(TENDANGNHAP)
    begin
       if (select count(*)
           from   _CODE_TAIKHOAN t1, inserted t2
           where  t1.TENDANGNHAP = t2.TENDANGNHAP) != @numrows
          begin
             select @errno  = 50002,
                    @errmsg = 'Parent does not exist in "_CODE_TAIKHOAN". Cannot create child in "_CODE_KHACHHANG".'
             goto error
          end
    end
    /*  The cardinality of Parent "_CODE_TAIKHOAN" in child "_CODE_KHACHHANG" cannot exceed 1 */
    if update(TENDANGNHAP)
    begin
       select @maxcard = (select count(*)
          from   _CODE_KHACHHANG old
          where ins.TENDANGNHAP = old.TENDANGNHAP)
       from  inserted ins
       where ins.TENDANGNHAP is not null
       group by ins.TENDANGNHAP
       order by 1
       if @maxcard > 1
       begin
          select @errno  = 50007,
                 @errmsg = 'The maximum cardinality of a child has been exceeded! Cannot create child in "_CODE_KHACHHANG".'
          goto error
       end
    end

    return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger TU__CODE_KHACHHANG on _CODE_KHACHHANG for update as
begin
   declare
      @maxcard  int,
      @numrows  int,
      @numnull  int,
      @errno    int,
      @errmsg   varchar(255)

      select  @numrows = @@rowcount
      if @numrows = 0
         return

      /*  Parent "_CODE_TAIKHOAN" must exist when updating a child in "_CODE_KHACHHANG"  */
      if update(TENDANGNHAP)
      begin
         if (select count(*)
             from   _CODE_TAIKHOAN t1, inserted t2
             where  t1.TENDANGNHAP = t2.TENDANGNHAP) != @numrows
            begin
               select @errno  = 50003,
                      @errmsg = '_CODE_TAIKHOAN" does not exist. Cannot modify child in "_CODE_KHACHHANG".'
               goto error
            end
      end
      /*  The cardinality of Parent "_CODE_TAIKHOAN" in child "_CODE_KHACHHANG" cannot exceed 1 */
      if update(TENDANGNHAP)
      begin
         select @maxcard = (select count(*)
            from   _CODE_KHACHHANG old
            where ins.TENDANGNHAP = old.TENDANGNHAP)
         from  inserted ins
         where ins.TENDANGNHAP is not null
         group by ins.TENDANGNHAP
         order by 1
         if @maxcard > 1
         begin
            select @errno  = 50007,
                   @errmsg = 'The maximum cardinality of a child has been exceeded! Cannot modify child in "_CODE_KHACHHANG".'
            goto error
         end
      end
      /*  Cannot modify parent code in "_CODE_KHACHHANG" if children still exist in "_CODE_HOADON"  */
      if update(MAKH)
      begin
         if exists (select 1
                    from   _CODE_HOADON t2, inserted i1, deleted d1
                    where  t2.MAKH = d1.MAKH
                     and  (i1.MAKH != d1.MAKH))
            begin
               select @errno  = 50005,
                      @errmsg = 'Children still exist in "_CODE_HOADON". Cannot modify parent code in "_CODE_KHACHHANG".'
               goto error
            end
      end


      return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger CLR_TRIGGER__CODE_NHANVIEN on _CODE_NHANVIEN  insert as
external name %Assembly.GeneratedName%.
go


create trigger TD__CODE_NHANVIEN on _CODE_NHANVIEN for delete as
begin
    declare
       @numrows  int,
       @errno    int,
       @errmsg   varchar(255)

    select  @numrows = @@rowcount
    if @numrows = 0
       return

    /*  Cannot delete parent "_CODE_NHANVIEN" if children still exist in "_CODE_HOADON"  */
    if exists (select 1
               from   _CODE_HOADON t2, deleted t1
               where  t2.MANV = t1.MANV)
       begin
          select @errno  = 50006,
                 @errmsg = 'Children still exist in "_CODE_HOADON". Cannot delete parent "_CODE_NHANVIEN".'
          goto error
       end


    return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger TI__CODE_NHANVIEN on _CODE_NHANVIEN for insert as
begin
    declare
       @maxcard  int,
       @numrows  int,
       @numnull  int,
       @errno    int,
       @errmsg   varchar(255)

    select  @numrows = @@rowcount
    if @numrows = 0
       return

    /*  Parent "_CODE_TAIKHOAN" must exist when inserting a child in "_CODE_NHANVIEN"  */
    if update(TENDANGNHAP)
    begin
       if (select count(*)
           from   _CODE_TAIKHOAN t1, inserted t2
           where  t1.TENDANGNHAP = t2.TENDANGNHAP) != @numrows
          begin
             select @errno  = 50002,
                    @errmsg = 'Parent does not exist in "_CODE_TAIKHOAN". Cannot create child in "_CODE_NHANVIEN".'
             goto error
          end
    end
    /*  The cardinality of Parent "_CODE_TAIKHOAN" in child "_CODE_NHANVIEN" cannot exceed 1 */
    if update(TENDANGNHAP)
    begin
       select @maxcard = (select count(*)
          from   _CODE_NHANVIEN old
          where ins.TENDANGNHAP = old.TENDANGNHAP)
       from  inserted ins
       where ins.TENDANGNHAP is not null
       group by ins.TENDANGNHAP
       order by 1
       if @maxcard > 1
       begin
          select @errno  = 50007,
                 @errmsg = 'The maximum cardinality of a child has been exceeded! Cannot create child in "_CODE_NHANVIEN".'
          goto error
       end
    end

    return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger TU__CODE_NHANVIEN on _CODE_NHANVIEN for update as
begin
   declare
      @maxcard  int,
      @numrows  int,
      @numnull  int,
      @errno    int,
      @errmsg   varchar(255)

      select  @numrows = @@rowcount
      if @numrows = 0
         return

      /*  Parent "_CODE_TAIKHOAN" must exist when updating a child in "_CODE_NHANVIEN"  */
      if update(TENDANGNHAP)
      begin
         if (select count(*)
             from   _CODE_TAIKHOAN t1, inserted t2
             where  t1.TENDANGNHAP = t2.TENDANGNHAP) != @numrows
            begin
               select @errno  = 50003,
                      @errmsg = '_CODE_TAIKHOAN" does not exist. Cannot modify child in "_CODE_NHANVIEN".'
               goto error
            end
      end
      /*  The cardinality of Parent "_CODE_TAIKHOAN" in child "_CODE_NHANVIEN" cannot exceed 1 */
      if update(TENDANGNHAP)
      begin
         select @maxcard = (select count(*)
            from   _CODE_NHANVIEN old
            where ins.TENDANGNHAP = old.TENDANGNHAP)
         from  inserted ins
         where ins.TENDANGNHAP is not null
         group by ins.TENDANGNHAP
         order by 1
         if @maxcard > 1
         begin
            select @errno  = 50007,
                   @errmsg = 'The maximum cardinality of a child has been exceeded! Cannot modify child in "_CODE_NHANVIEN".'
            goto error
         end
      end
      /*  Cannot modify parent code in "_CODE_NHANVIEN" if children still exist in "_CODE_HOADON"  */
      if update(MANV)
      begin
         if exists (select 1
                    from   _CODE_HOADON t2, inserted i1, deleted d1
                    where  t2.MANV = d1.MANV
                     and  (i1.MANV != d1.MANV))
            begin
               select @errno  = 50005,
                      @errmsg = 'Children still exist in "_CODE_HOADON". Cannot modify parent code in "_CODE_NHANVIEN".'
               goto error
            end
      end


      return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger CLR_TRIGGER__CODE_TAIKHOAN on _CODE_TAIKHOAN  insert as
external name %Assembly.GeneratedName%.
go


create trigger TD__CODE_TAIKHOAN on _CODE_TAIKHOAN for delete as
begin
    declare
       @numrows  int,
       @errno    int,
       @errmsg   varchar(255)

    select  @numrows = @@rowcount
    if @numrows = 0
       return

    /*  Cannot delete parent "_CODE_TAIKHOAN" if children still exist in "_CODE_KHACHHANG"  */
    if exists (select 1
               from   _CODE_KHACHHANG t2, deleted t1
               where  t2.TENDANGNHAP = t1.TENDANGNHAP)
       begin
          select @errno  = 50006,
                 @errmsg = 'Children still exist in "_CODE_KHACHHANG". Cannot delete parent "_CODE_TAIKHOAN".'
          goto error
       end

    /*  Cannot delete parent "_CODE_TAIKHOAN" if children still exist in "_CODE_NHANVIEN"  */
    if exists (select 1
               from   _CODE_NHANVIEN t2, deleted t1
               where  t2.TENDANGNHAP = t1.TENDANGNHAP)
       begin
          select @errno  = 50006,
                 @errmsg = 'Children still exist in "_CODE_NHANVIEN". Cannot delete parent "_CODE_TAIKHOAN".'
          goto error
       end


    return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go


create trigger TU__CODE_TAIKHOAN on _CODE_TAIKHOAN for update as
begin
   declare
      @numrows  int,
      @numnull  int,
      @errno    int,
      @errmsg   varchar(255)

      select  @numrows = @@rowcount
      if @numrows = 0
         return

      /*  Cannot modify parent code in "_CODE_TAIKHOAN" if children still exist in "_CODE_KHACHHANG"  */
      if update(TENDANGNHAP)
      begin
         if exists (select 1
                    from   _CODE_KHACHHANG t2, inserted i1, deleted d1
                    where  t2.TENDANGNHAP = d1.TENDANGNHAP
                     and  (i1.TENDANGNHAP != d1.TENDANGNHAP))
            begin
               select @errno  = 50005,
                      @errmsg = 'Children still exist in "_CODE_KHACHHANG". Cannot modify parent code in "_CODE_TAIKHOAN".'
               goto error
            end
      end

      /*  Cannot modify parent code in "_CODE_TAIKHOAN" if children still exist in "_CODE_NHANVIEN"  */
      if update(TENDANGNHAP)
      begin
         if exists (select 1
                    from   _CODE_NHANVIEN t2, inserted i1, deleted d1
                    where  t2.TENDANGNHAP = d1.TENDANGNHAP
                     and  (i1.TENDANGNHAP != d1.TENDANGNHAP))
            begin
               select @errno  = 50005,
                      @errmsg = 'Children still exist in "_CODE_NHANVIEN". Cannot modify parent code in "_CODE_TAIKHOAN".'
               goto error
            end
      end


      return

/*  Errors handling  */
error:
    raiserror @errno @errmsg
    rollback  transaction
end
go

/*------------------- INSERT ----------------------------*/

INSERT INTO TAIKHOAN
VALUES
  ("Colby",6000),
  ("Octavia",5548),
  ("Allistair",7899),
  ("Rafael",8491),
  ("Cecilia",9981),
  ("Quinn",6781),
  ("Ivana",8985),
  ("Timothy",9990),
  ("Fallon",7910),
  ("Cora",5010);
INSERT INTO TAIKHOAN
VALUES
  ("Daryl",7978),
  ("Bianca",3010),
  ("Quentin",1606),
  ("Cyrus",7032),
  ("Castor",8016),
  ("Eliana",1617),
  ("Aurora",7762),
  ("Evangeline",2316),
  ("Malik",2035),
  ("Blake",2426);
INSERT INTO TAIKHOAN
VALUES
  ("Abdul",8813),
  ("Joy",7125),
  ("Hilda",3226),
  ("Alexa",2941),
  ("Priscilla",9562),
  ("Xandra",2637),
  ("Ronan",8686),
  ("Wesley",2042),
  ("Kathleen",3650),
  ("Brittany",4733);
INSERT INTO TAIKHOAN
VALUES
  ("Murphy",4511),
  ("Rhea",2830),
  ("Brendan",6759),
  ("Jack",5851),
  ("Yoko",8315),
  ("Winifred",4986),
  ("Candice",6682),
  ("Marvin",8240),
  ("Dexter",8675),
  ("Angelica",2792);
INSERT INTO TAIKHOAN
VALUES
  ("Vernon",7937),
  ("Maya",5139),
  ("Timon",8182),
  ("Kennan",5215),
  ("Jade",1999),
  ("Uriah",8954),
  ("Hadley",9714),
  ("Baxter",4673),
  ("Rahim",7399),
  ("Sade",9023);
INSERT INTO TAIKHOAN
VALUES
  ("Mallory",8265),
  ("Mannix",5906),
  ("Serena",5269),
  ("Aimee",1439),
  ("Carolyn",6765),
  ("Cooper",8571),
  ("Petra",4904),
  ("Judith",6169),
  ("Driscoll",6687),
  ("Shelly",3380),
  ("Elijah",1548),
  ("Merritt",7034),
  ("Drew",7636),
  ("Macon",7497);

INSERT INTO TAIKHOAN
VALUES
  ("Victor",8857),
  ("Gay",5785),
  ("Illana",6594),
  ("Avram",9782),
  ("Basil",1524),
  ("Uriak",2073),
  ("Noelle",4806),
  ("Deacon",3146),
  ("Conan",2562),
  ("Lilah",8847);
INSERT INTO TAIKHOAN
VALUES
  ("Gavin",7779),
  ("Felix",4789),
  ("Sydnee",9427),
  ("Shana",7435),
  ("Callie",3525),
  ("Deanna",2919),
  ("Rebekah",8938),
  ("Cara",5804),
  ("Ali",6494),
  ("William",1175);

INSERT INTO KHACHHANG
VALUES
  ("","Colby","Colby Richmond","0766224933","dolor@odioaliquam.co.uk","NỮ"),
  ("","Octavia","Octavia Todd","0059201876","vehicula@metusfacilisislorem.com","NAM"),
  ("","Allistair","Allistair Harmon","0011551845","lacus.quisque@tristiquepellentesquetellus.co.uk","NAM"),
  ("","Rafael","Rafael Sparks","0263354718","phasellus@purus.edu","NAM"),
  ("","Cecilia","Cecilia Gilmore","0963623121","eu@eulacus.com","NỮ"),
  ("","Quinn","Quinn Bass","0740151289","risus.duis.a@dictumsapien.co.uk","NỮ"),
  ("","Ivana","Ivana Solomon","0277977066","curabitur.egestas@magnaet.edu","NAM"),
  ("","Timothy","Timothy Hensley","0684630282","odio@urnajustofaucibus.ca","NỮ"),
  ("","Fallon","Fallon Reid","0312580875","metus.sit.amet@vitaealiquet.com","NAM"),
  ("","Cora","Cora Rosario","0083293345","elit.sed@vulputatelacuscras.co.uk","NAM");
  
  INSERT INTO KHACHHANG
VALUES
  ("","Daryl","Daryl Hudson","0352615642","lacus@maurisrhoncusid.edu","NỮ"),
  ("","Bianca","Bianca Robinson","0723773634","quisque.tincidunt.pede@conguein.co.uk","NỮ"),
  ("","Quentin","Quentin Conner","0484274854","suspendisse.ac.metus@at.net","NAM"),
  ("","Cyrus","Cyrus Carpenter","0543382327","egestas.aliquam@pellentesqueut.org","NAM"),
  ("","Castor","Castor Nielsen","0616886120","duis.ac@utsagittislobortis.edu","NAM"),
  ("","Eliana","Eliana Wiley","0915493221","nulla.eu.neque@ultriciessem.com","NỮ"),
  ("","Aurora","Aurora Roach","0213391315","erat@cursusvestibulummauris.edu","NAM"),
  ("","Evangeline","Evangeline Rich","0391568616","vestibulum.lorem@ipsumdolor.edu","NỮ"),
  ("","Malik","Malik Espinoza","0718315362","egestas@mauriseuturpis.net","NAM"),
  ("","Blake","Blake Snow","0415397463","faucibus.orci.luctus@cum.org","NAM");
  
  INSERT INTO KHACHHANG
VALUES
  ("","Abdul","Abdul Leon","0432741325","eleifend@justo.co.uk","NỮ"),
  ("","Joy","Joy Harris","0355561112","augue.ac@lobortisclassaptent.com","NAM"),
  ("","Hilda","Hilda Cannon","0363130852","nulla@loremdonec.co.uk","NAM"),
  ("","Alexa","Alexa Oneal","0427102366","in.faucibus@orci.ca","NỮ"),
  ("","Priscilla","Priscilla Serrano","0326257961","nec.ligula.consectetuer@consequatlectussit.ca","NỮ"),
  ("","Xandra","Xandra Case","0636670280","ut.pharetra@cursuspurusnullam.ca","NỮ"),
  ("","Ronan","Ronan Davis","0143811292","sed.consequat@ut.ca","NAM"),
  ("","Wesley","Wesley Donaldson","0925717252","libero.at.auctor@senectus.ca","NAM"),
  ("","Kathleen","Kathleen Langley","0744381583","torquent@commodohendreritdonec.co.uk","NỮ"),
  ("","Brittany","Brittany Blake","0077473938","et.rutrum.non@gravidanunc.org","NAM");

INSERT INTO KHACHHANG
VALUES
  ("","Murphy","Murphy Mooney","0208622504","curae.phasellus@antebibendum.net","NỮ"),
  ("","Rhea","Rhea Hanson","0418318753","suspendisse.non.leo@faucibusleo.com","NAM"),
  ("","Brendan","Brendan Allison","0172110667","cras.eu@portaelit.com","NỮ"),
  ("","Jack","Jack Kaufman","0226694447","orci@curae.edu","NỮ"),
  ("","Yoko","Yoko Bradley","0412162635","semper@cursus.ca","NỮ"),
  ("","Winifred","Winifred Wong","0676184391","laoreet.posuere@quamcurabiturvel.com","NỮ"),
  ("","Candice","Candice Hyde","0951769321","et.ultrices.posuere@eteros.co.uk","NAM"),
  ("","Marvin","Marvin Guerrero","0110235134","orci.lobortis@pharetra.com","NỮ"),
  ("","Dexter","Dexter Franks","0332668966","ipsum.non@neque.net","NỮ"),
  ("","Angelica","Angelica Guy","0432296247","non.lobortis@metus.ca","NAM");

INSERT INTO KHACHHANG
VALUES
  ("","Vernon","Vernon Durham","0437111677","sed.auctor@erat.org","NỮ"),
  ("","Maya","Maya Preston","0828464256","libero.integer.in@aeneanmassa.co.uk","NAM"),
  ("","Timon","Timon Stuart","0188514707","pede@nequenullam.org","NỮ"),
  ("","Kennan","Kennan Andrews","0107138647","quam.dignissim@nuncpulvinar.com","NAM"),
  ("","Jade","Jade Knapp","0581302623","ipsum.sodales@curabiturutodio.com","NAM"),
  ("","Uriah","Uriah Mosley","0231905497","magna.lorem.ipsum@ac.edu","NAM"),
  ("","Hadley","Hadley Miller","0543131474","sed@felisdonec.co.uk","NAM"),
  ("","Baxter","Baxter Gomez","0223859868","donec.est@suspendisse.edu","NỮ"),
  ("","Rahim","Rahim Ramsey","0588568300","aenean.gravida@vel.ca","NỮ"),
  ("","Sade","Sade Beasley","0658985496","amet.luctus.vulputate@proin.co.uk","NỮ");
  
  INSERT INTO KHACHHANG
VALUES
  ("","Mallory","Mallory Case","0954851748","nulla@etrutrumeu.co.uk","NỮ"),
  ("","Mannix","Mannix Hoffman","0933716910","ut.tincidunt@nascetur.org","NỮ"),
  ("","Serena","Serena Howard","0217694121","integer.aliquam.adipiscing@nonleovivamus.edu","NỮ"),
  ("","Aimee","Aimee Lester","0117344275","dapibus.quam@felisullamcorper.net","NỮ"),
  ("","Carolyn","Carolyn Mclean","0225859520","lobortis.quam@quismassamauris.edu","NAM"),
  ("","Cooper","Cooper Delgado","0857161821","adipiscing@ligulaaeneaneuismod.com","NỮ"),
  ("","Petra","Petra Frazier","0618743178","rutrum@cursus.com","NAM"),
  ("","Judith","Judith Jarvis","0688818155","tincidunt.aliquam@arcuvestibulum.com","NAM"),
  ("","Driscoll","Driscoll Hester","0376660348","elit.fermentum.risus@ac.edu","NAM"),
  ("","Shelly","Shelly Cooley","0285788837","ligula.consectetuer@pretiumaliquetmetus.org","NỮ");
  
INSERT INTO NHANVIEN
VALUES
  ("","Victor","Victor Daniel","1981-02-10","NỮ","NV","Ap #960-1280 Molestie Road","2022-02-20","0037241169"),
  ("","Gay","Gay Ramos","1978-06-30","NAM","NV","Ap #978-6680 Ligula. Ave","2021-04-06","0217157522"),
  ("","Illana","Illana Keller","1988-04-09","NAM","NV","P.O. Box 542, 6803 Dui Ave","2020-10-03","0188404987"),
  ("","Avram","Avram Brennan","1996-10-29","NỮ","NV","P.O. Box 848, 3714 Aliquet St.","2020-11-17","0316289453"),
  ("","Basil","Basil Gomez","1998-04-14","NAM","QL","651-4022 Tristique Rd.","2020-09-16","0487099166"),
  ("","Uriak","Uriak Garrison","1990-05-02","NAM","NV","P.O. Box 933, 5192 Amet Ave","2021-09-01","0268959029"),
  ("","Noelle","Noelle Gomez","1992-08-24","NỮ","NV","Ap #205-753 Donec Av.","2021-08-30","0833656957"),
  ("","Deacon","Deacon Emerson","1990-05-13","NỮ","NV","8967 Magna. Av.","2021-03-02","0424127914"),
  ("","Conan","Conan Farley","1973-03-08","NAM","NV","624-1397 Donec Ave","2021-11-23","0712228906"),
  ("","Lilah","Lilah Wheeler","1987-07-26","NỮ","NV","P.O. Box 397, 4875 Nulla Av.","2020-04-01","0852728837");

INSERT INTO NHANVIEN
VALUES
  ("","Gavin","Gavin Wolfe","1983-12-01","NAM","NV","P.O. Box 121, 2976 Nunc St.","2020-06-06","0734158157"),
  ("","Felix","Felix Houston","1987-05-30","NỮ","NV","Ap #914-8010 Lacus, St.","2019-06-30","0683289218"),
  ("","Sydnee","Sydnee Bird","1991-07-15","NỮ","NV","897-5181 Lorem. Street","2020-05-27","0722776540"),
  ("","Shana","Shana Rose","1989-05-13","NỮ","NV","Ap #515-8505 Eu Rd.","2022-05-23","0146881148"),
  ("","Callie","Callie House","1984-06-06","NỮ","NV","Ap #590-7885 Id St.","2020-06-01","0466144184"),
  ("","Deanna","Deanna Black","1975-05-25","NAM","NV","2585 Magna St.","2019-04-05","0993140653"),
  ("","Rebekah","Rebekah Lott","1975-11-01","NỮ","NV","488-5782 Lorem Street","2020-11-29","0114256031"),
  ("","Cara","Cara Short","1979-01-09","NỮ","QL","7009 Sem St.","2020-03-22","0607545085"),
  ("","Ali","Ali Mercer","1990-02-09","NỮ","NV","477-848 Eget St.","2020-06-13","0632388282"),
  ("","William","William Foley","1992-02-06","NỮ","NV","Ap #536-3711 Litora Ave","2020-06-21","0619414581");

INSERT INTO NHANVIEN
VALUES
("","Drew","DEMO","2000-01-01","NAM","QL","DEMO","2022-02-02","0123456789");

INSERT INTO KHACHHANG
VALUES
("","Macon","DEMO","0123456789","DEMO@GMAIL.COM","NAM");
use laptop;
delete from NHANVIEN where MANV like 'NV%';
INSERT INTO BONHORAM
VALUES
("",""),
();

