#!/bin/sh
echo -ne '\033c\033]0;first game\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/first game.x86_64" "$@"
