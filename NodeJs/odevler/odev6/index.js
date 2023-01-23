const Koa = require("koa");
const app = new Koa();
const port = 3000;

app.use(async (ctx) => {
  const path = ctx.path;

  switch (path) {
    case "/":
      ctx.type = "text/html";
      ctx.body = "<h1>Anasayfaya Hoşgeldiniz</h1>";
      break;
    case "/about":
      ctx.type = "text/html";
      ctx.body = "<h1>Hakkında Sayfasına Hoşgeldiniz</h1>";
      break;
    case "/contact":
      ctx.type = "text/html";
      ctx.body = "<h1>İletişim Sayfasına Hoşgeldiniz</h1>";
      break;
    default:
      ctx.type = "text/html";
      ctx.body = "<h1>Sayfa Bulunamadı</h1>";
      break;
  }
});

app.listen(port, () => {
  console.log(` İşlem ${port} Port Nolu Sayfada Başladı `);
});