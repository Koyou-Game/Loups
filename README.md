# Loups

```
git clone --recurse-submodules git@github.com:Koyou-Game/Loups.git

git submodule update --init --recursive
```

# 架构设计

## Game Scene

- LevelController
    - LevelSketcher 这里负责加载地图

## Actor 参与者

- Actor
    - Character
        - Player
        - Enemy
        - NPC
    - Door
    - Platform

目前 Character 用于表示 玩家，敌人，NPC 等角色

现在把 Character，移动平台，门，机关等也放在 Actor 中 （ TODO 后续看怎么改）

# References

- [Feel Tutorial : Getting Started](https://www.youtube.com/watch?v=gK_7etknD4k)
- [【游戏制作工具箱】《蔚蓝》的手感为何迷人？Why Does Celeste Feel So Good to Play? | GMTK](https://www.bilibili.com/video/BV1M441197sr/?vd_source=b807ccf169a694309e37fab12df98df9)