CREATE DATABASE bookstore;

--
-- Database: bookinfo
--

-- --------------------------------------------------------

--
-- Table structure for table author
--

DROP TABLE author
CREATE TABLE author (
 aut_id varchar(8) NOT NULL DEFAULT '',
 aut_name varchar(50) NOT NULL DEFAULT '',
 country varchar(25) NOT NULL DEFAULT '',
 home_city varchar(25) NOT NULL DEFAULT '',
 PRIMARY KEY (aut_id)
)

--
-- Dumping data for table author
--

INSERT INTO author (aut_id, aut_name, country, home_city) VALUES
('AUT001', 'William Norton', 'UK', 'Cambridge'),
('AUT002', 'William Maugham', 'Canada', 'Toronto'),
('AUT003', 'William Anthony', 'UK', 'Leeds'),
('AUT004', 'S.B.Swaminathan', 'India', 'Bangalore'),
('AUT005', 'Thomas Morgan', 'Germany', 'Arnsberg'),
('AUT006', 'Thomas Merton', 'USA', 'New York'),
('AUT007', 'Piers Gibson', 'UK', 'London'),
('AUT008', 'Nikolai Dewey', 'USA', 'Atlanta'),
('AUT009', 'Marquis de Ellis', 'Brazil', 'Rio De Janerio'),
('AUT010', 'Joseph Milton', 'USA', 'Houston'),
('AUT011', 'John Betjeman Hunter', 'Australia', 'Sydney'),
('AUT012', 'Evan Hayek', 'Canada', 'Vancouver'),
('AUT013', 'E. Howard', 'Australia', 'Adelaide'),
('AUT014', 'C. J. Wilde', 'UK', 'London'),
('AUT015', 'Butler Andre', 'USA', 'Florida');

-- --------------------------------------------------------

--
-- Table structure for table book_mast
--

DROP TABLE book_mast
CREATE TABLE  book_mast (
 book_id varchar(15) NOT NULL DEFAULT '',
 book_name varchar(50) NOT NULL DEFAULT '',
 isbn_no varchar(15) NOT NULL DEFAULT '',
 cate_id varchar(8) NOT NULL DEFAULT '',
 aut_id varchar(8) NOT NULL DEFAULT '',
 pub_id varchar(8) NOT NULL DEFAULT '',
 dt_of_pub date NOT NULL DEFAULT '0000-00-00',
 pub_lang varchar(15) DEFAULT NULL,
 no_page decimal(5,0) NOT NULL DEFAULT '0',
 book_price decimal(8,2) NOT NULL DEFAULT '0.00',
 PRIMARY KEY (book_id)
)

--
-- Dumping data for table book_mast
--

INSERT INTO book_mast (book_id, book_name, isbn_no, cate_id, aut_id, pub_id, dt_of_pub, pub_lang, no_page, book_price) VALUES
('BK001', 'Introduction to Electrodynamics', '0000979001', 'CA001', 'AUT001', 'P003', '2001-05-08', 'English', '201', '85.00'),
('BK002', 'Understanding of Steel Construction', '0000979002', 'CA002', 'AUT002', 'P001', '2003-07-15', 'English', '300', '105.50'),
('BK003', 'Guide to Networking', '0000979003', 'CA003', 'AUT003', 'P002', '2002-09-10', 'Hindi', '510', '200.00'),
('BK004', 'Transfer  of Heat and Mass', '0000979004', 'CA002', 'AUT004', 'P004', '2004-02-16', 'English', '600', '250.00'),
('BK005', 'Conceptual Physics', '0000979005', 'CA001', 'AUT005', 'P006', '2003-07-16', NULL, '345', '145.00'),
('BK006', 'Fundamentals of Heat', '0000979006', 'CA001', 'AUT006', 'P005', '2003-08-10', 'German', '247', '112.00'),
('BK007', 'Advanced 3d Graphics', '0000979007', 'CA003', 'AUT007', 'P002', '2004-02-16', 'Hindi', '165', '56.00'),
('BK008', 'Human Anatomy', '0000979008', 'CA005', 'AUT008', 'P006', '2001-05-17', 'German', '88', '50.50'),
('BK009', 'Mental Health Nursing', '0000979009', 'CA005', 'AUT009', 'P007', '2004-02-10', 'English', '350', '145.00'),
('BK010', 'Fundamentals of Thermodynamics', '0000979010', 'CA002', 'AUT010', 'P007', '2002-10-14', 'English', '400', '225.00'),
('BK011', 'The Experimental Analysis of Cat', '0000979011', 'CA004', 'AUT011', 'P005', '2007-06-09', 'French', '225', '95.00'),
('BK012', 'The Nature  of World', '0000979012', 'CA004', 'AUT005', 'P008', '2005-12-20', 'English', '350', '88.00'),
('BK013', 'Environment a Sustainable Future', '0000979013', 'CA004', 'AUT012', 'P001', '2003-10-27', 'German', '165', '100.00'),
('BK014', 'Concepts in Health', '0000979014', 'CA005', 'AUT013', 'P004', '2001-08-25', NULL, '320', '180.00'),
('BK015', 'Anatomy & Physiology', '0000979015', 'CA005', 'AUT014', 'P008', '2000-10-10', 'Hindi', '225', '135.00'),
('BK016', 'Networks and Telecommunications', '00009790_16', 'CA003', 'AUT015', 'P003', '2002-01-01', 'French', '95', '45.00');

-- --------------------------------------------------------

--
-- Table structure for table category
--

DROP TABLE category
CREATE TABLE  category (
 cate_id varchar(8) NOT NULL DEFAULT '',
 cate_descrip varchar(25) NOT NULL DEFAULT '',
 PRIMARY KEY (cate_id)
)

--
-- Dumping data for table category
--

INSERT INTO category (cate_id, cate_descrip) VALUES
('CA001', 'Science'),
('CA002', 'Technology'),
('CA003', 'Computers'),
('CA004', 'Nature'),
('CA005', 'Medical');

-- --------------------------------------------------------

--
-- Table structure for table despatch
--

DROP TABLE despatch
CREATE TABLE  despatch (
 desp_no varchar(8) NOT NULL DEFAULT '',
 desp_data date NOT NULL DEFAULT '0000-00-00',
 client_city varchar(15) NOT NULL DEFAULT '',
 client_country varchar(15) NOT NULL DEFAULT '',
 book_id varchar(8) NOT NULL DEFAULT '',
 aut_id varchar(8) NOT NULL DEFAULT '',
 no_of_copy int NOT NULL DEFAULT 0,
 sell_price decimal(12,2) NOT NULL DEFAULT '0.00',
 disc_per decimal(5,2) NOT NULL DEFAULT '0.00',
 total_cost decimal(12,2) NOT NULL DEFAULT '0.00',
 PRIMARY KEY (desp_no)
)

--
-- Dumping data for table despatch
--


-- --------------------------------------------------------

--
-- Table structure for table newpublisher
--

DROP TABLE newpublisher
CREATE TABLE  newpublisher (
 pub_id varchar(8) NOT NULL DEFAULT '',
 pub_name varchar(50) NOT NULL DEFAULT '',
 pub_city varchar(25) NOT NULL DEFAULT '',
 country varchar(25) NOT NULL DEFAULT '',
 country_office varchar(25) NOT NULL DEFAULT '',
 no_of_branch int DEFAULT 0,
 estd date DEFAULT '0000-00-00'
)

--
-- Dumping data for table newpublisher
--

INSERT INTO newpublisher (pub_id, pub_name, pub_city, country, country_office, no_of_branch, estd) VALUES
('P001', 'Jex Max Publication', 'New York', 'USA', 'New York', 15, '1969-12-25'),
('P002', 'BPP Publication', 'Mumbai', 'India', 'New Delhi', 10, '1985-10-01'),
('P003', 'New Harrold Publication', 'Adelaide', 'Australia', 'Sydney', 6, NULL),
('P004', 'Ultra Press Inc.', 'London', 'UK', 'London', 8, '1948-07-10'),
('P005', 'Mountain Publication', 'Houstan', 'USA', 'Sun Diego', 25, NULL),
('P006', 'Summer Night Publication', 'New York', 'USA', 'Atlanta', 10, '1990-12-10'),
('P007', 'Pieterson Grp. of Publishers', 'Cambridge', 'UK', 'London', 6, NULL),
('P008', 'Novel Publisher Ltd.', 'New Delhi', 'India', 'Bangalore', 10, '2000-01-01'),
('a001', 'žÚÝB>ËA‰Ë0R+ñ¦', ' ', ' ', ' ', 5, '2000-01-01');

-- --------------------------------------------------------

--
-- Table structure for table order
--

DROP TABLE orders
CREATE TABLE  orders (
 ord_no varchar(15) NOT NULL DEFAULT '',
 ord_date date NOT NULL DEFAULT '0000-00-00',
 book_id varchar(15) NOT NULL DEFAULT '',
 book_name varchar(50) NOT NULL DEFAULT '',
 cate_id varchar(8) NOT NULL DEFAULT '',
 pub_lang varchar(15) NOT NULL DEFAULT '',
 ord_qty int NOT NULL DEFAULT 0,
 PRIMARY KEY (ord_no)
)

--
-- Dumping data for table order
--


-- --------------------------------------------------------

--
-- Table structure for table publisher
--

DROP TABLE publisher
CREATE TABLE  publisher (
 pub_id varchar(8) NOT NULL DEFAULT '',
 pub_name varchar(50) NOT NULL DEFAULT '',
 pub_city varchar(25) NOT NULL DEFAULT '',
 country varchar(25) NOT NULL DEFAULT '',
 country_office varchar(25) NOT NULL DEFAULT '',
 no_of_branch int NOT NULL DEFAULT 0,
 estd date NOT NULL DEFAULT '0000-00-00',
 PRIMARY KEY (pub_id)
)

--
-- Dumping data for table publisher
--

INSERT INTO publisher (pub_id, pub_name, pub_city, country, country_office, no_of_branch, estd) VALUES
('P001', 'Jex Max Publication', 'New York', 'USA', 'New York', 15, '1969-12-25'),
('P002', 'BPP Publication', 'Mumbai', 'India', 'New Delhi', 10, '1985-10-01'),
('P003', 'New Harrold Publication', 'Adelaide', 'Australia', 'Sydney', 6, '1975-09-05'),
('P004', 'Ultra Press Inc.', 'London', 'UK', 'London', 8, '1948-07-10'),
('P005', 'Mountain Publication', 'Houstan', 'USA', 'Sun Diego', 25, '1975-01-01'),
('P006', 'Summer Night Publication', 'New York', 'USA', 'Atlanta', 10, '1990-12-10'),
('P007', 'Pieterson Grp. of Publishers', 'Cambridge', 'UK', 'London', 6, '1950-07-15'),
('P008', 'Novel Publisher Ltd.', 'New Delhi', 'India', 'Bangalore', 10, '2000-01-01');

-- --------------------------------------------------------

--
-- Table structure for table purchase
--

DROP TABLE purchase
CREATE TABLE  purchase (
 invoice_no varchar(12) NOT NULL DEFAULT '',
 invoice_dt date NOT NULL DEFAULT '0000-00-00',
 ord_no varchar(25) NOT NULL,
 ord_date date NOT NULL DEFAULT '0000-00-00',
 receive_dt date NOT NULL DEFAULT '0000-00-00',
 book_id varchar(8) NOT NULL DEFAULT '',
 book_name varchar(50) NOT NULL DEFAULT '',
 pub_lang varchar(8) DEFAULT NULL,
 cate_id varchar(8) DEFAULT NULL,
 receive_qty int NOT NULL DEFAULT 0,
 purch_price decimal(12,2) NOT NULL DEFAULT '0.00',
 total_cost decimal(12,2) NOT NULL DEFAULT '0.00',
 PRIMARY KEY (invoice_no)
)

--
-- Dumping data for table purchase
--

INSERT INTO purchase (invoice_no, invoice_dt, ord_no, ord_date, receive_dt, book_id, book_name, pub_lang, cate_id, receive_qty, purch_price, total_cost) VALUES
('INV0001', '2008-07-15', 'ORD/08-09/0001', '2008-07-06', '2008-07-19', 'BK001', 'Introduction to Electrodynamics', 'English', 'CA001', 15, '75.00', '1125.00'),
('INV0002', '2008-08-25', 'ORD/08-09/0002', '2008-08-09', '2008-08-28', 'BK004', 'Transfer  of Heat and Mass', 'English', 'CA002', 8, '55.00', '440.00'),
('INV0003', '2008-09-20', 'ORD/08-09/0003', '2008-09-15', '2008-09-23', 'BK005', 'Conceptual Physics', NULL, 'CA001', 20, '20.00', '400.00'),
('INV0004', '2007-08-30', 'ORD/07-08/0005', '2007-08-22', '2007-08-30', 'BK004', 'Transfer  of Heat and Mass', 'English', 'CA002', 15, '35.00', '525.00'),
('INV0005', '2007-07-28', 'ORD/07-08/0004', '2007-06-25', '2007-07-30', 'BK001', 'Introduction to Electrodynamics', 'English', 'CA001', 8, '25.00', '200.00'),
('INV0006', '2007-09-24', 'ORD/07-08/0007', '2007-09-20', '2007-09-30', 'BK003', 'Guide to Networking', 'Hindi', 'CA003', 20, '45.00', '900.00');

-- --------------------------------------------------------

--
-- Table structure for table testtable
--

DROP TABLE testtable
CREATE TABLE  testtable (
 description varchar(25) NOT NULL
)

--
-- Dumping data for table testtable
--

INSERT INTO testtable (description) VALUES
('^5[@·˜,IÜç¦Éý'),
('Ô£^]Žþª_‹m'),
('ÿ»(õ 2ñ«QèªöjD¸=ËTú9Ž!');

-- --------------------------------------------------------

--
-- List all tables
--

SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'

--
-- Select all data from all tables
--

DECLARE @sqlText VARCHAR(MAX)
SET @sqlText = ''
SELECT @sqlText = @sqlText + ' SELECT * FROM ' + QUOTENAME(name) + CHAR(13) FROM sys.tables
EXEC(@sqlText)

--
-- Select all books with its name, authors name, category name, publishers name and price
--

SELECT book_name, aut_name, cate_descrip, pub_name, book_price
FROM book_mast, author, category, newpublisher
WHERE book_mast.aut_id = author.aut_id
AND book_mast.cate_id = category.cate_id
AND book_mast.pub_id = newpublisher.pub_id
ORDER BY book_name ASC
