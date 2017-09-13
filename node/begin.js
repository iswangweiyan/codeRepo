//加载http模块
const http = require('http');

//主机名和端口
const hostname = '127.0.0.1';
const port = 3000;

//创建一个服务器 req,res请求体和相应体
const server = http.createServer((req, res) => {
  res.statusCode = 200; //返回的状态是成功
  res.setHeader('Content-Type', 'text/plain'); //返回的内容是纯文本
  res.end('Hello World\n');
  
});

//监听函数
server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);


});