import { Button, Container, Divider, Paper, Typography } from "@mui/material";
import { Link } from "react-router-dom";

export default function NotFound() {
    return (
        <Container component={Paper} sx={{height: 400}}>
            <Typography gutterBottom variant='h3'>Oops! We're unable to find what you are looking for.</Typography>
            <Divider />
            <Button fullWidth component={Link} to='/catalog'>Return to Shop</Button>
        </Container>

    )
}