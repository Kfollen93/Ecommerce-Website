import { DarkMode } from "@mui/icons-material";
import { AppBar, Switch, Toolbar, Typography } from "@mui/material";

interface Props {
    darkMode: boolean;
    handleThemeSwitch: () => void;
}
export default function Header({ darkMode, handleThemeSwitch }: Props) {
    return (
        <AppBar position='static' sx={{mb: 4}} >
            <Toolbar>
                <Typography variant='h6'>
                    Electronics Store
                </Typography>
                <Switch color="secondary" checked={darkMode} onChange={handleThemeSwitch} />
            </Toolbar>
        </AppBar>
    )
}