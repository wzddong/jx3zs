# jx3zs
基于酷Q的剑网三便捷查询插件
免费，开源

基于 Native.SDK

## Native.SDK 环境部署
详情请看 Wiki: https://github.com/Jie2GG/Native.Csharp.Frame/wiki

## Native.SDK 调试流程

    1. 打开 酷Q Air/Pro, 并且登录机器人账号
    2. 打开 Native.Csharp 项目, 修改 "生成" 中的 "输出路径" 为 酷Q的 "dev" 路径
    3. 重新生成 Native.Csharp 项目
    4. 在酷Q上使用 "重载应用" 功能, 重载所有应用
    5. 依次选择VS的菜单项: "调试" -> "附加到进程"
    6. 选择 CQA.exe/CQP.exe 的托管进程, 选择附加
    7. 附加成功后进入调试模式, 即可进行断点 (注: 仅在只加载一个 .Net 应用的酷Q可以进行调试)