# Đồ án Hệ thống thẻ thành viên đa dịch vụ cho Nhà Văn hóa Sinh viên TP HCM
Công nghệ:
- .Net 8.0
- PostgreSQL
- ReactJS
- 
**Các điều cần chú ý:**
1. Dự án dùng kiến trúc API - Service - Repository
2. Common là nơi lưu các tiện ích và các class gốc để phân trang, trả response api theo quy chuẩn,...
3. Có 2 appsetting:
   - Development: để chạy database cho app local, test local.
   - Production: để chạy database cho app deploy.
