# GoogleTranslateCLI v1.0.0
GoogleTranslateCLI

Đây là một ứng dụng dòng lệnh đơn giản để dịch văn bản từ tiếng Anh sang tiếng Việt và ngược lại sử dụng Google Translate API.
Các tính năng

Dịch văn bản từ tiếng Anh sang tiếng Việt và ngược lại
Hỗ trợ các tùy chọn:
    -s hoặc --sourceLanguage: Ngôn ngữ nguồn, mặc định là tiếng Anh
    -t hoặc --targetLanguage: Ngôn ngữ đích, mặc định là tiếng Việt
    -q hoặc --query: Văn bản cần dịch
Xuất kết quả dịch ra màn hình console
Các


Hướng dẫn sử dụng

Chạy chương trình với cú pháp:


    GoogleTranslateCLI -s <ngôn_ngữ_nguồn> -t <ngôn_ngữ_đích> -q <văn_bản_cần_dịch>


Ví dụ:


    GoogleTranslateCLI -s en -t vi -q "Hello world"
    

Sẽ dịch cụm từ "Hello world" từ tiếng Anh sang tiếng Việt.
Yêu cầu

.NET Core 3.1 hoặc cao hơn
Package CommandLineParser
